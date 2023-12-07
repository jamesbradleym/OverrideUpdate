using Elements;
using Elements.Geometry;
using System.Collections.Generic;

namespace OverrideUpdate
{
    public static class OverrideUpdate
    {
        /// <summary>
        /// The OverrideUpdate function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A OverrideUpdateOutputs instance containing computed results and the model with any new elements.</returns>
        public static OverrideUpdateOutputs Execute(Dictionary<string, Model> inputModels, OverrideUpdateInputs input)
        {
            // Your code here.
            var height = 1.0;
            var selectedOptionalNumber = ValidateNumericEnum(input.OptionalNumberEnum, 1.0);
            var width = selectedOptionalNumber;
            var length = selectedOptionalNumber;
            var name = ValidateStringEnum(input.OptionalStringEnum, "One");
            var volume = length * width * height;
            var output = new OverrideUpdateOutputs(volume);
            var rectangle = Polygon.Rectangle(length, width);

            var massOptions = new MassOptions
            {
                Options = GenerateValidOptions(selectedOptionalNumber)
            };
            output.Model.AddElement(massOptions);

            var mass = new MyMass(rectangle, height)
            {
                Name = name,
                // Apply a default value
                Option = massOptions.Options.First()
            };

            input.Overrides.Options.Apply(
              new List<MyMass>() { mass },
              (mass, identity) => mass.Name == identity.Name,
              (mass, edit) =>
              {
                  // Check if the selected option is valid
                  var optionIsValid = massOptions.Options.Contains(edit.Value.Option);
                  if (optionIsValid)
                  {
                      // Apply the user selection because it is valid
                      mass.Option = edit.Value.Option;
                  }
                  else
                  {
                      // Apply a default if the selected value is no longer valid
                      mass.Option = massOptions.Options.Last();
                  }
                  return mass;
              }
            );

            output.Model.AddElement(mass);
            return output;
        }

        public static double ValidateNumericEnum(double? enumValue, double initial = 1.0)
        {
            if (!enumValue.HasValue)
            {
                return initial;
            }
            return enumValue.Value;
        }
        public static string ValidateStringEnum(OverrideUpdateInputsOptionalStringEnum? enumValue, string initial = "One")
        {
            if (!enumValue.HasValue)
            {
                return initial;
            }
            return enumValue.Value.ToString();
        }

        public static List<string> GenerateValidOptions(double input)
        {
            var PrimaryOptions = new List<string>() {
                  "Option A",
                  "Option B",
                  "Option C",
                  "Option D",
                  "Option E",
                  "Option F",
                };
            return PrimaryOptions.GetRange(0, (int)input);
        }
    }
}