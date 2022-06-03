// Reference: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll, 2022-04-01T06:49:44.0000000+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll, 2021-12-13T15:00:53.7959649+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Configuration\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.dll, 2021-10-06T15:44:35.9755386+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll, 2022-01-19T04:57:45.8289532+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll, 2019-12-07T10:10:37.7737543+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.Composition\v4.0_4.0.0.0__b77a5c561934e089\System.ComponentModel.Composition.dll, 2019-12-07T10:10:36.1023351+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Autofac.Integration.Wcf.dll, 2018-05-24T21:27:04.0000000+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Activation\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Activation.dll, 2019-12-07T10:10:36.0558875+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel\v4.0_4.0.0.0__b77a5c561934e089\System.ServiceModel.dll, 2021-10-12T05:15:24.8586707+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Web\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Web.dll, 2021-10-06T15:44:35.9755386+02:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_32\System.Web\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.dll, 2022-02-26T10:53:22.0000000+01:00
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll, 2021-10-12T05:15:24.8586707+02:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Rhetos.Interfaces.dll, 2021-03-05T15:23:46.0000000+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.commonconcepts\4.3.0\lib\net472\Rhetos.Dom.DefaultConcepts.Interfaces.dll, 2021-03-05T16:24:00.0000000+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Rhetos.Logging.Interfaces.dll, 2021-03-05T15:23:40.0000000+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Rhetos.Processing.Interfaces.dll, 2021-03-05T15:23:44.0000000+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Rhetos.Utilities.dll, 2021-03-05T15:23:42.0000000+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Rhetos.XmlSerialization.dll, 2021-03-05T15:23:46.0000000+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Rhetos.Web.dll, 2021-03-05T15:23:46.0000000+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.restgenerator\4.0.0\lib\net472\Rhetos.RestGenerator.dll, 2020-09-23T16:37:12.0000000+02:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.commonconcepts\4.3.0\lib\net472\Rhetos.Processing.DefaultCommands.Interfaces.dll, 2021-03-05T16:24:00.0000000+01:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Newtonsoft.Json.dll, 2019-04-22T01:06:16.0000000+02:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.msbuild\4.3.0\tools\Autofac.dll, 2019-08-15T13:05:20.0000000+02:00
// Reference: C:\Users\ncrnogorac\.nuget\packages\rhetos.commonconcepts\4.3.0\lib\net472\Rhetos.Dom.DefaultConcepts.dll, 2021-03-05T16:24:00.0000000+01:00
// Debug = "False"

#pragma warning disable // Ignore unused namespaces.
using Autofac;
using Rhetos.Dom.DefaultConcepts;
using Rhetos.RestGenerator.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Net;
using System.Text;
/*InitialCodeGenerator.UsingTag*/
#pragma warning restore // Ignore unused namespaces.

namespace RestService
{
    public class RestServiceHostFactory : Autofac.Integration.Wcf.AutofacServiceHostFactory
    {
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new RestServiceHost(serviceType, baseAddresses);
        }
    }

    public class RestServiceHost : WebServiceHost
    {
        public RestServiceHost(Type serviceType, Uri[] baseAddresses)
            : base(serviceType, baseAddresses) { }

        protected override void OnOpening()
        {
            /*InitialCodeGenerator.ServiceHostOnOpeningBeginTag*/
            var wcfCreatesDefaultBindingsOnOpening = Description.Endpoints.Count == 0;
            // WebServiceHost will automatically create HTTP and HTTPS REST-like endpoints/binding/behaviors pairs, if service endpoint/binding/behavior configuration is empty 
            // After OnOpening setup, we will setup default binding sizes, if needed
            base.OnOpening();
            /*InitialCodeGenerator.ServiceHostOnOpeningTag*/

            if (wcfCreatesDefaultBindingsOnOpening)
            {
                const int sizeInBytes = 200 * 1024 * 1024;
                foreach (var binding in Description.Endpoints.Select(x => x.Binding as WebHttpBinding))
                {
                    binding.MaxReceivedMessageSize = sizeInBytes;
                    binding.ReaderQuotas.MaxArrayLength = sizeInBytes;
                    binding.ReaderQuotas.MaxStringContentLength = sizeInBytes;
                    /*InitialCodeGenerator.ServiceHostOnOpeningDefaultBindingTag*/
                }
            }

            if (Description.Behaviors.Find<Rhetos.Web.JsonErrorServiceBehavior>() == null)
                Description.Behaviors.Add(new Rhetos.Web.JsonErrorServiceBehavior());
            /*InitialCodeGenerator.ServiceHostOnOpeningEndTag*/
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Module))]
    public class RestServiceModuleConfiguration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<QueryParameters>().InstancePerLifetimeScope();
            builder.RegisterType<ServiceUtility>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(DataRestService<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ActionRestService<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ReportRestService<>)).InstancePerLifetimeScope();
            /*InitialCodeGenerator.ServiceRegistrationTag*/
            base.Load(builder);
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Rhetos.IService))]
    public class RestServiceInitializer : Rhetos.IService
    {
        public void Initialize()
        {
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/Book", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.Book>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/BookInfo", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.BookInfo>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/BookTopic", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.BookTopic>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/ChildrensBook", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.ChildrensBook>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/Comment", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.Comment>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/Employee", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.Employee>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/ForeignBook", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.ForeignBook>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/Genre", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.Genre>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/Insert5Books", new RestServiceHostFactory(), typeof(ActionRestService<Bookstore.Insert5Books>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/InsertManyBooks", new RestServiceHostFactory(), typeof(ActionRestService<Bookstore.InsertManyBooks>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/Person", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.Person>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/Topic", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.Topic>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/AddToLog", new RestServiceHostFactory(), typeof(ActionRestService<Common.AddToLog>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/AutoCodeCache", new RestServiceHostFactory(), typeof(DataRestService<Common.AutoCodeCache>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/Claim", new RestServiceHostFactory(), typeof(DataRestService<Common.Claim>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/ExclusiveLock", new RestServiceHostFactory(), typeof(DataRestService<Common.ExclusiveLock>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/FilterId", new RestServiceHostFactory(), typeof(DataRestService<Common.FilterId>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/KeepSynchronizedMetadata", new RestServiceHostFactory(), typeof(DataRestService<Common.KeepSynchronizedMetadata>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/Log", new RestServiceHostFactory(), typeof(DataRestService<Common.Log>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/LogReader", new RestServiceHostFactory(), typeof(DataRestService<Common.LogReader>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/LogRelatedItem", new RestServiceHostFactory(), typeof(DataRestService<Common.LogRelatedItem>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/LogRelatedItemReader", new RestServiceHostFactory(), typeof(DataRestService<Common.LogRelatedItemReader>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/Principal", new RestServiceHostFactory(), typeof(DataRestService<Common.Principal>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/PrincipalHasRole", new RestServiceHostFactory(), typeof(DataRestService<Common.PrincipalHasRole>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/PrincipalPermission", new RestServiceHostFactory(), typeof(DataRestService<Common.PrincipalPermission>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/RelatedEventsSource", new RestServiceHostFactory(), typeof(DataRestService<Common.RelatedEventsSource>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/ReleaseLock", new RestServiceHostFactory(), typeof(ActionRestService<Common.ReleaseLock>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/Role", new RestServiceHostFactory(), typeof(DataRestService<Common.Role>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/RoleInheritsRole", new RestServiceHostFactory(), typeof(DataRestService<Common.RoleInheritsRole>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/RolePermission", new RestServiceHostFactory(), typeof(DataRestService<Common.RolePermission>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/SetLock", new RestServiceHostFactory(), typeof(ActionRestService<Common.SetLock>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Bookstore/BookStoreGrid", new RestServiceHostFactory(), typeof(DataRestService<Bookstore.BookStoreGrid>)));
            System.Web.Routing.RouteTable.Routes.Add(new System.ServiceModel.Activation.ServiceRoute(
                "Rest/Common/MyClaim", new RestServiceHostFactory(), typeof(DataRestService<Common.MyClaim>)));
            /*InitialCodeGenerator.ServiceInitializationTag*/
        }

        public void InitializeApplicationInstance(System.Web.HttpApplication context)
        {
            /*InitialCodeGenerator.ServiceInstanceInitializationTag*/
        }
    }

    public static class RestServiceMetadata
    {
        #pragma warning disable CA1825 // Avoid zero-length array allocations. Some metadata can be empty, available to be extended by plugins.

        public static Tuple<string, Type>[] Get_Bookstore_Book_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Bookstore.ComplexSearch", typeof(Bookstore.ComplexSearch)),
                Tuple.Create("ComplexSearch", typeof(Bookstore.ComplexSearch)),
                Tuple.Create("Bookstore.AverageBooks", typeof(Bookstore.AverageBooks)),
                Tuple.Create("AverageBooks", typeof(Bookstore.AverageBooks)),
                Tuple.Create("Bookstore.CommonMisspelling", typeof(Bookstore.CommonMisspelling)),
                Tuple.Create("CommonMisspelling", typeof(Bookstore.CommonMisspelling)),
                Tuple.Create("Bookstore.ContainsLockMark", typeof(Bookstore.ContainsLockMark)),
                Tuple.Create("ContainsLockMark", typeof(Bookstore.ContainsLockMark)),
                Tuple.Create("Bookstore.LongBooks", typeof(Bookstore.LongBooks)),
                Tuple.Create("LongBooks", typeof(Bookstore.LongBooks)),
                Tuple.Create("Bookstore.ShortBooks", typeof(Bookstore.ShortBooks)),
                Tuple.Create("ShortBooks", typeof(Bookstore.ShortBooks)),
                Tuple.Create("Bookstore.SystemRequiredActive", typeof(Bookstore.SystemRequiredActive)),
                Tuple.Create("SystemRequiredActive", typeof(Bookstore.SystemRequiredActive)),
                Tuple.Create("Bookstore.SystemRequiredCode", typeof(Bookstore.SystemRequiredCode)),
                Tuple.Create("SystemRequiredCode", typeof(Bookstore.SystemRequiredCode)),
                Tuple.Create("Bookstore.LongBooks3", typeof(Bookstore.LongBooks3)),
                Tuple.Create("LongBooks3", typeof(Bookstore.LongBooks3)),
                Tuple.Create("Rhetos.Dom.DefaultConcepts.ActiveItems", typeof(Rhetos.Dom.DefaultConcepts.ActiveItems)),
                Tuple.Create("ActiveItems", typeof(Rhetos.Dom.DefaultConcepts.ActiveItems)),
                Tuple.Create("Bookstore.ShortBooks2", typeof(Bookstore.ShortBooks2)),
                Tuple.Create("ShortBooks2", typeof(Bookstore.ShortBooks2)),
                /*DataStructureInfo FilterTypes Bookstore.Book*/ };
        public static Tuple<string, Type>[] Get_Bookstore_BookInfo_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Bookstore.BookInfo*/ };
        public static Tuple<string, Type>[] Get_Bookstore_BookTopic_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Bookstore.SystemRequiredBook", typeof(Bookstore.SystemRequiredBook)),
                Tuple.Create("SystemRequiredBook", typeof(Bookstore.SystemRequiredBook)),
                /*DataStructureInfo FilterTypes Bookstore.BookTopic*/ };
        public static Tuple<string, Type>[] Get_Bookstore_ChildrensBook_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Bookstore.AgeFrom_AgeTo_RangeFilter", typeof(Bookstore.AgeFrom_AgeTo_RangeFilter)),
                Tuple.Create("AgeFrom_AgeTo_RangeFilter", typeof(Bookstore.AgeFrom_AgeTo_RangeFilter)),
                /*DataStructureInfo FilterTypes Bookstore.ChildrensBook*/ };
        public static Tuple<string, Type>[] Get_Bookstore_Comment_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Bookstore.SystemRequiredBook", typeof(Bookstore.SystemRequiredBook)),
                Tuple.Create("SystemRequiredBook", typeof(Bookstore.SystemRequiredBook)),
                /*DataStructureInfo FilterTypes Bookstore.Comment*/ };
        public static Tuple<string, Type>[] Get_Bookstore_Employee_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Bookstore.Employee*/ };
        public static Tuple<string, Type>[] Get_Bookstore_ForeignBook_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Bookstore.ForeignBook*/ };
        public static Tuple<string, Type>[] Get_Bookstore_Genre_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Bookstore.Genre*/ };
        public static Tuple<string, Type>[] Get_Bookstore_Person_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Bookstore.Person*/ };
        public static Tuple<string, Type>[] Get_Bookstore_Topic_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Bookstore.Topic*/ };
        public static Tuple<string, Type>[] Get_Common_AutoCodeCache_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.AutoCodeCache*/ };
        public static Tuple<string, Type>[] Get_Common_Claim_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Common.SystemRequiredActive", typeof(Common.SystemRequiredActive)),
                Tuple.Create("SystemRequiredActive", typeof(Common.SystemRequiredActive)),
                Tuple.Create("Rhetos.Dom.DefaultConcepts.ActiveItems", typeof(Rhetos.Dom.DefaultConcepts.ActiveItems)),
                Tuple.Create("ActiveItems", typeof(Rhetos.Dom.DefaultConcepts.ActiveItems)),
                /*DataStructureInfo FilterTypes Common.Claim*/ };
        public static Tuple<string, Type>[] Get_Common_ExclusiveLock_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.ExclusiveLock*/ };
        public static Tuple<string, Type>[] Get_Common_FilterId_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.FilterId*/ };
        public static Tuple<string, Type>[] Get_Common_KeepSynchronizedMetadata_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.KeepSynchronizedMetadata*/ };
        public static Tuple<string, Type>[] Get_Common_Log_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.Log*/ };
        public static Tuple<string, Type>[] Get_Common_LogReader_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.LogReader*/ };
        public static Tuple<string, Type>[] Get_Common_LogRelatedItem_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Common.SystemRequiredLog", typeof(Common.SystemRequiredLog)),
                Tuple.Create("SystemRequiredLog", typeof(Common.SystemRequiredLog)),
                /*DataStructureInfo FilterTypes Common.LogRelatedItem*/ };
        public static Tuple<string, Type>[] Get_Common_LogRelatedItemReader_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.LogRelatedItemReader*/ };
        public static Tuple<string, Type>[] Get_Common_Principal_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.Principal*/ };
        public static Tuple<string, Type>[] Get_Common_PrincipalHasRole_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Common.SystemRequiredPrincipal", typeof(Common.SystemRequiredPrincipal)),
                Tuple.Create("SystemRequiredPrincipal", typeof(Common.SystemRequiredPrincipal)),
                Tuple.Create("Rhetos.Dom.DefaultConcepts.IPrincipal", typeof(Rhetos.Dom.DefaultConcepts.IPrincipal)),
                Tuple.Create("IPrincipal", typeof(Rhetos.Dom.DefaultConcepts.IPrincipal)),
                /*DataStructureInfo FilterTypes Common.PrincipalHasRole*/ };
        public static Tuple<string, Type>[] Get_Common_PrincipalPermission_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Common.SystemRequiredClaim", typeof(Common.SystemRequiredClaim)),
                Tuple.Create("SystemRequiredClaim", typeof(Common.SystemRequiredClaim)),
                Tuple.Create("Common.SystemRequiredPrincipal", typeof(Common.SystemRequiredPrincipal)),
                Tuple.Create("SystemRequiredPrincipal", typeof(Common.SystemRequiredPrincipal)),
                /*DataStructureInfo FilterTypes Common.PrincipalPermission*/ };
        public static Tuple<string, Type>[] Get_Common_RelatedEventsSource_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.RelatedEventsSource*/ };
        public static Tuple<string, Type>[] Get_Common_Role_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Common.Role*/ };
        public static Tuple<string, Type>[] Get_Common_RoleInheritsRole_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Common.SystemRequiredUsersFrom", typeof(Common.SystemRequiredUsersFrom)),
                Tuple.Create("SystemRequiredUsersFrom", typeof(Common.SystemRequiredUsersFrom)),
                /*DataStructureInfo FilterTypes Common.RoleInheritsRole*/ };
        public static Tuple<string, Type>[] Get_Common_RolePermission_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Common.SystemRequiredClaim", typeof(Common.SystemRequiredClaim)),
                Tuple.Create("SystemRequiredClaim", typeof(Common.SystemRequiredClaim)),
                Tuple.Create("Common.SystemRequiredRole", typeof(Common.SystemRequiredRole)),
                Tuple.Create("SystemRequiredRole", typeof(Common.SystemRequiredRole)),
                /*DataStructureInfo FilterTypes Common.RolePermission*/ };
        public static Tuple<string, Type>[] Get_Bookstore_BookStoreGrid_FilterTypes() => new Tuple<string, Type>[] {
                /*DataStructureInfo FilterTypes Bookstore.BookStoreGrid*/ };
        public static Tuple<string, Type>[] Get_Common_MyClaim_FilterTypes() => new Tuple<string, Type>[] {
                Tuple.Create("Common.Claim", typeof(Common.Claim)),
                Tuple.Create("Claim", typeof(Common.Claim)),
                Tuple.Create("IEnumerable<Common.Claim>", typeof(IEnumerable<Common.Claim>)),
                /*DataStructureInfo FilterTypes Common.MyClaim*/ };
        /*InitialCodeGenerator.RestServiceMetadataMembersTag*/

        // This is separated from generic rest service class, because a static field in a generic type is not shared among instances of different close constructed types.
        private static readonly ConcurrentDictionary<string, Tuple<string, Type>[]> FilterTypesByDataStructure = new ConcurrentDictionary<string, Tuple<string, Type>[]>();

        public static Tuple<string,Type>[] GetFilterTypesByDataStructure(string dataStructureName) => FilterTypesByDataStructure.GetOrAdd(dataStructureName, GetFilterTypesByDataStructureName);

        private static Tuple<string, Type>[] GetFilterTypesByDataStructureName(string dataStructureName)
        {
            return typeof(RestServiceMetadata)
                .GetMethod($"Get_{ dataStructureName.Replace('.', '_')}_FilterTypes")
                  .Invoke(null, Array.Empty<object>()) as Tuple<string, Type>[];
        }

        public static readonly HashSet<string> WritableDataStructures = new HashSet<string>(new string[]
        {
            "Bookstore.Book",
            "Bookstore.BookTopic",
            "Bookstore.ChildrensBook",
            "Bookstore.Comment",
            "Bookstore.Employee",
            "Bookstore.ForeignBook",
            "Bookstore.Genre",
            "Bookstore.Person",
            "Bookstore.Topic",
            "Common.AutoCodeCache",
            "Common.Claim",
            "Common.ExclusiveLock",
            "Common.FilterId",
            "Common.KeepSynchronizedMetadata",
            "Common.Log",
            "Common.LogRelatedItem",
            "Common.Principal",
            "Common.PrincipalHasRole",
            "Common.PrincipalPermission",
            "Common.Role",
            "Common.RoleInheritsRole",
            "Common.RolePermission",
            /*InitialCodeGenerator.WritableDataStructuresTag*/
        });

        #pragma warning restore CA1825 // Avoid zero-length array allocations.
    }

#pragma warning disable CS0618 // 'LegacyClientException' is obsolete: 'Use ClientException instead.'

    [ServiceContract]
    /*InitialCodeGenerator.DataRestServiceAttributesTag*/
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class DataRestService<TDataStructure> where TDataStructure : class, IEntity, new()
    {
        private readonly ServiceUtility _serviceUtility;
        /*InitialCodeGenerator.DataRestServicePropertiesTag*/

        public DataRestService(ServiceUtility serviceUtility/*InitialCodeGenerator.DataRestServiceConstructorParameterTag*/)
        {
            _serviceUtility = serviceUtility;
            /*InitialCodeGenerator.DataRestServiceConstructorTag*/
        }

        // Obsolete parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsResult<TDataStructure> Get(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            var data = _serviceUtility.GetData<TDataStructure>(filter, fparam, genericfilter, filters, RestServiceMetadata.GetFilterTypesByDataStructure(typeof(TDataStructure).FullName), top, skip, page, psize, sort,
                readRecords: true, readTotalCount: false);
            return new RecordsResult<TDataStructure> { Records = data.Records };
        }

        [Obsolete("Use GetTotalCount instead.")]
        [OperationContract]
        [WebGet(UriTemplate = "/Count?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public CountResult GetCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<TDataStructure>(filter, fparam, genericfilter, filters, RestServiceMetadata.GetFilterTypesByDataStructure(typeof(TDataStructure).FullName), 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new CountResult { TotalRecords = data.TotalCount };
        }

        // Obsolete parameters: filter, fparam, genericfilter (use filters).
        [OperationContract]
        [WebGet(UriTemplate = "/TotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TotalCountResult GetTotalCount(string filter, string fparam, string genericfilter, string filters, string sort)
        {
            var data = _serviceUtility.GetData<TDataStructure>(filter, fparam, genericfilter, filters, RestServiceMetadata.GetFilterTypesByDataStructure(typeof(TDataStructure).FullName), 0, 0, 0, 0, sort,
                readRecords: false, readTotalCount: true);
            return new TotalCountResult { TotalCount = data.TotalCount };
        }

        // Obsolete parameters: filter, fparam, genericfilter (use filters), page, psize (use top and skip).
        [OperationContract]
        [WebGet(UriTemplate = "/RecordsAndTotalCount?filter={filter}&fparam={fparam}&genericfilter={genericfilter}&filters={filters}&top={top}&skip={skip}&page={page}&psize={psize}&sort={sort}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public RecordsAndTotalCountResult<TDataStructure> GetRecordsAndTotalCount(string filter, string fparam, string genericfilter, string filters, int top, int skip, int page, int psize, string sort)
        {
            return _serviceUtility.GetData<TDataStructure>(filter, fparam, genericfilter, filters, RestServiceMetadata.GetFilterTypesByDataStructure(typeof(TDataStructure).FullName), top, skip, page, psize, sort,
                readRecords: true, readTotalCount: true);
        }

        [OperationContract]
        [WebGet(UriTemplate = "/{id}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public TDataStructure GetById(string id)
        {
            var result = _serviceUtility.GetDataById<TDataStructure>(id);
            if (result == null)
                throw new Rhetos.LegacyClientException("There is no resource of this type with a given ID.") { HttpStatusCode = HttpStatusCode.NotFound, Severe = false };
            return result;
        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public InsertDataResult Insert(TDataStructure entity)
        {
            if (!RestServiceMetadata.WritableDataStructures.Contains(typeof(TDataStructure).FullName))
                throw new Rhetos.ClientException($"Invalid request: '{typeof(TDataStructure).FullName}' is not writable.");
            if (entity == null)
                throw new Rhetos.ClientException("Invalid request: Missing the record data. The data should be provided in the request message body.");
            if (Guid.Empty == entity.ID)
                entity.ID = Guid.NewGuid();

            _serviceUtility.InsertData(entity);
            return new InsertDataResult { ID = entity.ID };
        }

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void Update(string id, TDataStructure entity)
        {
            if (!RestServiceMetadata.WritableDataStructures.Contains(typeof(TDataStructure).FullName))
                throw new Rhetos.ClientException($"Invalid request: '{typeof(TDataStructure).FullName}' is not writable.");
            if (entity == null)
                throw new Rhetos.ClientException("Invalid request: Missing the record data. The data should be provided in the request message body.");
            if (!Guid.TryParse(id, out Guid guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parameter 'ID'.");
            if (Guid.Empty == entity.ID)
                entity.ID = guid;
            if (guid != entity.ID)
                throw new Rhetos.LegacyClientException("Given entity ID is not equal to resource ID from URI.");

            _serviceUtility.UpdateData(entity);
        }

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "{id}", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void Delete(string id)
        {
            if (!RestServiceMetadata.WritableDataStructures.Contains(typeof(TDataStructure).FullName))
                throw new Rhetos.ClientException($"Invalid request: '{typeof(TDataStructure).FullName}' is not writable.");
            if (!Guid.TryParse(id, out Guid guid))
                throw new Rhetos.LegacyClientException("Invalid format of GUID parameter 'ID'.");
            var entity = new TDataStructure { ID = guid };

            _serviceUtility.DeleteData(entity);
        }

        /*InitialCodeGenerator.DataRestServiceMethodsTag*/
    }

    [ServiceContract]
    /*InitialCodeGenerator.ActionRestServiceAttributesTag*/
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ActionRestService<TDataStructure> where TDataStructure : class, new()
    {
        private readonly ServiceUtility _serviceUtility;
        /*InitialCodeGenerator.ActionRestServicePropertiesTag*/

        public ActionRestService(ServiceUtility serviceUtility/*InitialCodeGenerator.ActionRestServiceConstructorParameterTag*/)
        {
            _serviceUtility = serviceUtility;
            /*InitialCodeGenerator.ActionRestServiceConstructorTag*/
        }

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public void Execute(TDataStructure action)
        {
            _serviceUtility.Execute<TDataStructure>(action);
        }

        /*InitialCodeGenerator.ActionRestServiceMethodsTag*/
    }

    [ServiceContract]
    /*InitialCodeGenerator.ReportRestServiceAttributesTag*/
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ReportRestService<TDataStructure> where TDataStructure : class, new()
    {
        private readonly ServiceUtility _serviceUtility;
        /*InitialCodeGenerator.ReportRestServicePropertiesTag*/

        public ReportRestService(ServiceUtility serviceUtility/*InitialCodeGenerator.ReportRestServiceConstructorParameterTag*/)
        {
            _serviceUtility = serviceUtility;
            /*InitialCodeGenerator.ReportRestServiceConstructorTag*/
        }

        [OperationContract]
        [WebGet(UriTemplate = "/?parameter={parameter}&convertFormat={convertFormat}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        public DownloadReportResult DownloadReport(string parameter, string convertFormat)
        {
            return _serviceUtility.DownloadReport<TDataStructure>(parameter, convertFormat);
        }

        /*InitialCodeGenerator.ReportRestServiceMethodsTag*/
    }

    /*InitialCodeGenerator.RhetosRestClassesTag*/

#pragma warning restore CS0618 // 'LegacyClientException' is obsolete: 'Use ClientException instead.'
}
