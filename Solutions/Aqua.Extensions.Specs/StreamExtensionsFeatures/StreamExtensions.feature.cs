// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Aqua.Extensions.Specs.StreamExtensionsFeatures
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("StreamExtensions")]
    public partial class StreamExtensionsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StreamExtensions.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StreamExtensions", "\tIn order to make common stream patterns more usable\r\n\tAs a developer\r\n\tI want to" +
                    " be able to convert various types of object to a string", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Convert a stream to a byte array")]
        public virtual void ConvertAStreamToAByteArray()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Convert a stream to a byte array", null, ((string[])(null)));
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table69 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table69.AddRow(new string[] {
                        "1"});
            table69.AddRow(new string[] {
                        "10"});
            table69.AddRow(new string[] {
                        "2"});
            table69.AddRow(new string[] {
                        "8"});
            table69.AddRow(new string[] {
                        "255"});
            table69.AddRow(new string[] {
                        "0"});
            table69.AddRow(new string[] {
                        "42"});
            table69.AddRow(new string[] {
                        "42"});
#line 7
 testRunner.Given("the following bytes in a stream", ((string)(null)), table69, "Given ");
#line 17
 testRunner.When("I get the bytes from the stream", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table70 = new TechTalk.SpecFlow.Table(new string[] {
                        "Value"});
            table70.AddRow(new string[] {
                        "1"});
            table70.AddRow(new string[] {
                        "10"});
            table70.AddRow(new string[] {
                        "2"});
            table70.AddRow(new string[] {
                        "8"});
            table70.AddRow(new string[] {
                        "255"});
            table70.AddRow(new string[] {
                        "0"});
            table70.AddRow(new string[] {
                        "42"});
            table70.AddRow(new string[] {
                        "42"});
#line 18
 testRunner.Then("the result should match", ((string)(null)), table70, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
