using DataDyneIntentLibrary;
using ModuleBase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExampleModule
{
    public class ExampleModule : ModuleBaseClass, IModule
    {
        public override string Description => "An example basic module";

        //Replace this GUID with a unique one
        public override string GUID => "19EBEA55-511E-45B0-B18F-02F54DC26002";

        public override string ModuleName => "Example Module";

        public override string ResourceDictionaryName => "ExampleModuleResourceDictionary";

        public override string AssemblyName => "ExampleModule";

        public override string DataTemplateName => "ExampleDataTemplate";

        public override ModuleViewModelBase GetViewModel()
        {
            return new ExampleModuleViewModel(GUID);
        }

        protected override Command[] CreateCommands()
        {
            var exampleCommand = new Command();
            exampleCommand.CommandName = "Example";
            exampleCommand.CommandIdentifier = "ExampleCommand";
            exampleCommand.Description = "Example of a Command";
            var exampleSlot = new CommandSlot("SomeValue", "int");
            exampleCommand.Slots = new CommandSlot[] { exampleSlot };

            return new Command[] { exampleCommand };

        }

        protected override Dictionary<string, Func<DataDyneIntent, Task<Response>>> CreateMappings()
        {
            var mappings = new Dictionary<string, Func<DataDyneIntent, Task<Response>>>();

            mappings.Add("ExampleCommand", ExampleMethod);

            return mappings;
        }

        private async Task<Response> ExampleMethod(DataDyneIntent intent)
        {
            //Perform action here
            

            return Response.EmptySuccess;
        }

        protected override Dictionary<string, string> GetDefaultSettings()
        {
            return new Dictionary<string, string>()
            {
                { "Setting1", "Default setting" },
                { "Setting2", "true" }
            };
        }
    }
}
