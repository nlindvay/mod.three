using mod.two.lib;

namespace mod.three.lib
{
    public class ModThreeClass
    {

        public string GetTwoClassString() => InstanceOfModTwoClass.Blah();

        public string GetIt() => "ModThreeClass.GetIt()";

        public ModTwoClass InstanceOfModTwoClass { get; set; }

        public string GetThreeClassString()
        {
            return "ModThreeClass.GetModThreeString()";
        }
    }
}