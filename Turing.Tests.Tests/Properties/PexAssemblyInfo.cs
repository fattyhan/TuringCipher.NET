// <copyright file="PexAssemblyInfo.cs" company="AXF Software">Copyright ©  2016</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("AXFSoftware.Security.Cryptography.Turing.Tests")]
[assembly: PexInstrumentAssembly("xunit.assert")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("xunit.core")]
[assembly: PexInstrumentAssembly("AXFSoftware.Security.Cryptography.Turing")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "xunit.assert")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "xunit.core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "AXFSoftware.Security.Cryptography.Turing")]

