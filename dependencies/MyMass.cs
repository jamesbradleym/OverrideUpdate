using Elements.Geometry;

namespace Elements
{
    public partial class MyMass : Mass
    {
        public List<string> Options { get; set; }
        public MyMass(Profile profile, double height = 1, Material material = null, Transform transform = null, Representation representation = null, bool isElementDefinition = false, Guid id = default, string name = null) : base(profile, height, material, transform, representation, isElementDefinition, id, name)
        {
        }
    }
}