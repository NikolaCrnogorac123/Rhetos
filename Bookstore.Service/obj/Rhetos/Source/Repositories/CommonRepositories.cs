﻿namespace Common._Helper
{
    #pragma warning disable // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Common*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private AddToLog_Repository _AddToLog_Repository;
        public AddToLog_Repository AddToLog { get { return _AddToLog_Repository ?? (_AddToLog_Repository = (AddToLog_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AddToLog")); } }

        private AutoCodeCache_Repository _AutoCodeCache_Repository;
        public AutoCodeCache_Repository AutoCodeCache { get { return _AutoCodeCache_Repository ?? (_AutoCodeCache_Repository = (AutoCodeCache_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AutoCodeCache")); } }

        private Claim_Repository _Claim_Repository;
        public Claim_Repository Claim { get { return _Claim_Repository ?? (_Claim_Repository = (Claim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Claim")); } }

        private ExclusiveLock_Repository _ExclusiveLock_Repository;
        public ExclusiveLock_Repository ExclusiveLock { get { return _ExclusiveLock_Repository ?? (_ExclusiveLock_Repository = (ExclusiveLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ExclusiveLock")); } }

        private FilterId_Repository _FilterId_Repository;
        public FilterId_Repository FilterId { get { return _FilterId_Repository ?? (_FilterId_Repository = (FilterId_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.FilterId")); } }

        private KeepSynchronizedMetadata_Repository _KeepSynchronizedMetadata_Repository;
        public KeepSynchronizedMetadata_Repository KeepSynchronizedMetadata { get { return _KeepSynchronizedMetadata_Repository ?? (_KeepSynchronizedMetadata_Repository = (KeepSynchronizedMetadata_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.KeepSynchronizedMetadata")); } }

        private Log_Repository _Log_Repository;
        public Log_Repository Log { get { return _Log_Repository ?? (_Log_Repository = (Log_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Log")); } }

        private LogReader_Repository _LogReader_Repository;
        public LogReader_Repository LogReader { get { return _LogReader_Repository ?? (_LogReader_Repository = (LogReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogReader")); } }

        private LogRelatedItem_Repository _LogRelatedItem_Repository;
        public LogRelatedItem_Repository LogRelatedItem { get { return _LogRelatedItem_Repository ?? (_LogRelatedItem_Repository = (LogRelatedItem_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItem")); } }

        private LogRelatedItemReader_Repository _LogRelatedItemReader_Repository;
        public LogRelatedItemReader_Repository LogRelatedItemReader { get { return _LogRelatedItemReader_Repository ?? (_LogRelatedItemReader_Repository = (LogRelatedItemReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItemReader")); } }

        private Principal_Repository _Principal_Repository;
        public Principal_Repository Principal { get { return _Principal_Repository ?? (_Principal_Repository = (Principal_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Principal")); } }

        private PrincipalHasRole_Repository _PrincipalHasRole_Repository;
        public PrincipalHasRole_Repository PrincipalHasRole { get { return _PrincipalHasRole_Repository ?? (_PrincipalHasRole_Repository = (PrincipalHasRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalHasRole")); } }

        private PrincipalPermission_Repository _PrincipalPermission_Repository;
        public PrincipalPermission_Repository PrincipalPermission { get { return _PrincipalPermission_Repository ?? (_PrincipalPermission_Repository = (PrincipalPermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalPermission")); } }

        private RelatedEventsSource_Repository _RelatedEventsSource_Repository;
        public RelatedEventsSource_Repository RelatedEventsSource { get { return _RelatedEventsSource_Repository ?? (_RelatedEventsSource_Repository = (RelatedEventsSource_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RelatedEventsSource")); } }

        private ReleaseLock_Repository _ReleaseLock_Repository;
        public ReleaseLock_Repository ReleaseLock { get { return _ReleaseLock_Repository ?? (_ReleaseLock_Repository = (ReleaseLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ReleaseLock")); } }

        private Role_Repository _Role_Repository;
        public Role_Repository Role { get { return _Role_Repository ?? (_Role_Repository = (Role_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Role")); } }

        private RoleInheritsRole_Repository _RoleInheritsRole_Repository;
        public RoleInheritsRole_Repository RoleInheritsRole { get { return _RoleInheritsRole_Repository ?? (_RoleInheritsRole_Repository = (RoleInheritsRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RoleInheritsRole")); } }

        private RolePermission_Repository _RolePermission_Repository;
        public RolePermission_Repository RolePermission { get { return _RolePermission_Repository ?? (_RolePermission_Repository = (RolePermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RolePermission")); } }

        private SetLock_Repository _SetLock_Repository;
        public SetLock_Repository SetLock { get { return _SetLock_Repository ?? (_SetLock_Repository = (SetLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.SetLock")); } }

        private MyClaim_Repository _MyClaim_Repository;
        public MyClaim_Repository MyClaim { get { return _MyClaim_Repository ?? (_MyClaim_Repository = (MyClaim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.MyClaim")); } }

        /*ModuleInfo RepositoryMembers Common*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AddToLog*/
    public class AddToLog_Repository : /*DataStructureInfo OverrideBaseType Common.AddToLog*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.AddToLog*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.AddToLog*/

        public AddToLog_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.AddToLog*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.AddToLog*/
        }

        public void Execute(Common.AddToLog actionParameter)
        {
            Action<Common.AddToLog, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.AddToLog*/> action_Object = (parameter, repository, userInfo) =>
		{
			if (parameter.Action == null)
				throw new Rhetos.UserException("Parameter Action is required.");
			string sql = @"INSERT INTO Common.Log (Action, TableName, ItemId, Description)
                SELECT @p0, @p1, @p2, @p3";
			_executionContext.EntityFrameworkContext.Database.ExecuteSqlCommand(sql,
				parameter.Action,
				parameter.TableName,
				parameter.ItemId,
				parameter.Description);
		};

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.AddToLog*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.AddToLog*/);
                /*ActionInfo AfterAction Common.AddToLog*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.AddToLog) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.AddToLog*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AutoCodeCache*/
    public class AutoCodeCache_Repository : /*DataStructureInfo OverrideBaseType Common.AutoCodeCache*/ Common.OrmRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.QueryableRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.ReadableRepositoryBase<Common.AutoCodeCache> // global::Common.RepositoryBase
        , IWritableRepository<Common.AutoCodeCache>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.AutoCodeCache*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.AutoCodeCache*/

        public AutoCodeCache_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.AutoCodeCache*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.AutoCodeCache*/
        }

        public virtual void Save(IEnumerable<Common.AutoCodeCache> insertedNew, IEnumerable<Common.AutoCodeCache> updatedNew, IEnumerable<Common.AutoCodeCache> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.AutoCodeCache*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Entity, newItem, "Common", "AutoCodeCache", "Entity");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Grouping, newItem, "Common", "AutoCodeCache", "Grouping");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Prefix, newItem, "Common", "AutoCodeCache", "Prefix");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Property, newItem, "Common", "AutoCodeCache", "Property");

            /*DataStructureInfo WritableOrm ArgumentValidation Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm Initialization Common.AutoCodeCache*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_AutoCodeCache> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_AutoCodeCache> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.AutoCodeCache*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.AutoCodeCache", @"IX_AutoCodeCache_Entity_Property_Grouping_Prefix"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.AutoCodeCache,Property:Entity Property Grouping Prefix";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.AutoCodeCache*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.AutoCodeCache");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_AutoCodeCache> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.AutoCodeCache*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.AutoCodeCache*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.AutoCodeCache");

                /*DataStructureInfo WritableOrm AfterSave Common.AutoCodeCache*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.AutoCodeCache*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.AutoCodeCache*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Claim*/
    public class Claim_Repository : /*DataStructureInfo OverrideBaseType Common.Claim*/ Common.OrmRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.QueryableRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.ReadableRepositoryBase<Common.Claim> // global::Common.RepositoryBase
        , IWritableRepository<Common.Claim>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Claim*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Claim*/

        public Claim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Claim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Claim*/
        }

        // Claims in use should be deactivated instead of deleted.
        public IEnumerable<Claim> Filter(IEnumerable<Claim> deleted, Rhetos.Dom.DefaultConcepts.DeactivateInsteadOfDelete parameter)
        {
            var deactivateClaimsId = new List<Guid>();
            var deletedClaimsId = new Lazy<List<Guid>>(() => deleted.Select(c => c.ID).ToList());

            {
                // Don't delete claims that are referenced from RolePermission:

                var permissionsQuery = _domRepository.Common.RolePermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            
            {
                // Don't delete claims that are referenced from PrincipalPermission:

                var permissionsQuery = _domRepository.Common.PrincipalPermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            /*DataStructureInfo DeactivateInsteadOfDelete Common.Claim*/

            var deactivateClaimsIdIndex = new HashSet<Guid>(deactivateClaimsId);
            return deleted.Where(item => deactivateClaimsIdIndex.Contains(item.ID)).ToList();
        }

        public virtual void Save(IEnumerable<Common.Claim> insertedNew, IEnumerable<Common.Claim> updatedNew, IEnumerable<Common.Claim> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Claim*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.ClaimResource, newItem, "Common", "Claim", "ClaimResource");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.ClaimRight, newItem, "Common", "Claim", "ClaimRight");

            /*DataStructureInfo WritableOrm ArgumentValidation Common.Claim*/

            /*DataStructureInfo WritableOrm Initialization Common.Claim*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_Claim> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_Claim> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            DeactivatableCodeGenerator.SetActiveByDefault(insertedNew, updatedNew, updated);

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Claim*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimResource == null || string.IsNullOrWhiteSpace(item.ClaimResource) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimResource*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimResource" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimResource", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimRight == null || string.IsNullOrWhiteSpace(item.ClaimRight) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimRight*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimRight" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimRight", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Claim*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"ClaimID", @"FK_PrincipalPermission_Claim_ClaimID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"ClaimID", @"FK_RolePermission_Claim_ClaimID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Claim", @"IX_Claim_ClaimResource_ClaimRight"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Claim,Property:ClaimResource ClaimRight";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.Claim*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.Claim");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Claim> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Claim*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Claim*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Claim");

                /*DataStructureInfo WritableOrm AfterSave Common.Claim*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredActive()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredActive(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Claim*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredActive(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredActive";
            metadata[@"Property"] = @"Active";
            /*InvalidDataInfo ErrorMetadata Common.Claim.SystemRequiredActive*/
            /*InvalidDataInfo CustomValidationResult Common.Claim.SystemRequiredActive*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Bool Common.Claim.Active" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> source, Common.SystemRequiredActive parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.Claim.'Common.SystemRequiredActive'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/
            
            return source.Where(item => item.Active == null);
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> items, Rhetos.Dom.DefaultConcepts.ActiveItems parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            
            if (parameter != null && parameter.ItemID.HasValue)
                            return items.Where(item => item.Active == null || item.Active.Value || item.ID == parameter.ItemID.Value);
                        else
                            return items.Where(item => item.Active == null || item.Active.Value);
        }

        /*DataStructureInfo RepositoryMembers Common.Claim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ExclusiveLock*/
    public class ExclusiveLock_Repository : /*DataStructureInfo OverrideBaseType Common.ExclusiveLock*/ Common.OrmRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.QueryableRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.ReadableRepositoryBase<Common.ExclusiveLock> // global::Common.RepositoryBase
        , IWritableRepository<Common.ExclusiveLock>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.ExclusiveLock*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.ExclusiveLock*/

        public ExclusiveLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.ExclusiveLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.ExclusiveLock*/
        }

        public virtual void Save(IEnumerable<Common.ExclusiveLock> insertedNew, IEnumerable<Common.ExclusiveLock> updatedNew, IEnumerable<Common.ExclusiveLock> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.ExclusiveLock*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.ResourceType, newItem, "Common", "ExclusiveLock", "ResourceType");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.UserName, newItem, "Common", "ExclusiveLock", "UserName");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Workstation, newItem, "Common", "ExclusiveLock", "Workstation");

            /*DataStructureInfo WritableOrm ArgumentValidation Common.ExclusiveLock*/

            /*DataStructureInfo WritableOrm Initialization Common.ExclusiveLock*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_ExclusiveLock> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_ExclusiveLock> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.ExclusiveLock*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockFinish == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockFinish*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockFinish" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockFinish", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockStart == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockStart*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockStart" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockStart", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceID == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceID*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceID" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceType == null || string.IsNullOrWhiteSpace(item.ResourceType) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceType*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceType" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceType", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "UserName" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "Workstation" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.ExclusiveLock*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.ExclusiveLock", @"IX_ExclusiveLock_ResourceID_ResourceType"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.ExclusiveLock,Property:ResourceID ResourceType";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.ExclusiveLock*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.ExclusiveLock");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_ExclusiveLock> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.ExclusiveLock*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.ExclusiveLock*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.ExclusiveLock");

                /*DataStructureInfo WritableOrm AfterSave Common.ExclusiveLock*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.ExclusiveLock*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.ExclusiveLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.FilterId*/
    public class FilterId_Repository : /*DataStructureInfo OverrideBaseType Common.FilterId*/ Common.OrmRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.QueryableRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.ReadableRepositoryBase<Common.FilterId> // global::Common.RepositoryBase
        , IWritableRepository<Common.FilterId>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.FilterId*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.FilterId*/

        public FilterId_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.FilterId*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.FilterId*/
        }

        /// <summary>
        /// Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
        /// EF 6.1.3 has performance issues on Contains function with large lists. It seems to have O(n^2) time complexity.
        /// </summary>
        public IEnumerable<Guid> CreateQueryableFilterIds(IEnumerable<Guid> ids)
        {
            Rhetos.Utilities.CsUtility.Materialize(ref ids);

            if (ids.Count() < 200)
                return ids;

            var handle = Guid.NewGuid();
            string sqlInsertIdFormat = "INSERT INTO Common.FilterId (Handle, Value) VALUES ('" + SqlUtility.GuidToString(handle) + "', '{0}');";

            const int chunkSize = 1000; // Keeping a moderate SQL script size.
            for (int start = 0; start < ids.Count(); start += chunkSize)
            {
                string sqlInsertIds = string.Join("\r\n", ids.Skip(start).Take(chunkSize)
                        .Select(id => string.Format(sqlInsertIdFormat, SqlUtility.GuidToString(id))));
                _executionContext.SqlExecuter.ExecuteSql(sqlInsertIds);
            }

            // Delete temporary data when closing the connection. The data must remain in the database until the returned query is used.
            string deleteFilterIds = "DELETE FROM Common.FilterId WHERE Handle = " + SqlUtility.QuoteGuid(handle);
            _executionContext.PersistenceTransaction.BeforeClose += () =>
                {
                    try
                    {
                        _executionContext.SqlExecuter.ExecuteSql(deleteFilterIds);
                    }
                    catch
                    {
                        // Cleanup error may be ignored. The temporary data may be deleted on regular maintenance.
                    }
                };

            return Query().Where(filterId => filterId.Handle == handle).Select(filterId => filterId.Value.Value);
        }

        public virtual void Save(IEnumerable<Common.FilterId> insertedNew, IEnumerable<Common.FilterId> updatedNew, IEnumerable<Common.FilterId> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.FilterId*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.FilterId*/

            /*DataStructureInfo WritableOrm Initialization Common.FilterId*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_FilterId> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_FilterId> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.FilterId*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.FilterId*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.FilterId*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.FilterId");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_FilterId> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.FilterId*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.FilterId*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.FilterId");

                /*DataStructureInfo WritableOrm AfterSave Common.FilterId*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.FilterId*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.FilterId*/
    }

    /*DataStructureInfo RepositoryAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata_Repository : /*DataStructureInfo OverrideBaseType Common.KeepSynchronizedMetadata*/ Common.OrmRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.QueryableRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.ReadableRepositoryBase<Common.KeepSynchronizedMetadata> // global::Common.RepositoryBase
        , IWritableRepository<Common.KeepSynchronizedMetadata>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.KeepSynchronizedMetadata*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.KeepSynchronizedMetadata*/

        public KeepSynchronizedMetadata_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.KeepSynchronizedMetadata*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.KeepSynchronizedMetadata*/
        }

        public virtual void Save(IEnumerable<Common.KeepSynchronizedMetadata> insertedNew, IEnumerable<Common.KeepSynchronizedMetadata> updatedNew, IEnumerable<Common.KeepSynchronizedMetadata> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.KeepSynchronizedMetadata*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Source, newItem, "Common", "KeepSynchronizedMetadata", "Source");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Target, newItem, "Common", "KeepSynchronizedMetadata", "Target");

            /*DataStructureInfo WritableOrm ArgumentValidation Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm Initialization Common.KeepSynchronizedMetadata*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.KeepSynchronizedMetadata*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.KeepSynchronizedMetadata*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.KeepSynchronizedMetadata");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.KeepSynchronizedMetadata*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.KeepSynchronizedMetadata*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.KeepSynchronizedMetadata");

                /*DataStructureInfo WritableOrm AfterSave Common.KeepSynchronizedMetadata*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.KeepSynchronizedMetadata*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.KeepSynchronizedMetadata*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Log*/
    public class Log_Repository : /*DataStructureInfo OverrideBaseType Common.Log*/ Common.OrmRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.QueryableRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.ReadableRepositoryBase<Common.Log> // global::Common.RepositoryBase
        , IWritableRepository<Common.Log>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Log*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Log*/

        public Log_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Log*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Log*/
        }

        public virtual void Save(IEnumerable<Common.Log> insertedNew, IEnumerable<Common.Log> updatedNew, IEnumerable<Common.Log> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Log*/

            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.Log" }, null, null);
            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Action, newItem, "Common", "Log", "Action");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.ContextInfo, newItem, "Common", "Log", "ContextInfo");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.TableName, newItem, "Common", "Log", "TableName");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.UserName, newItem, "Common", "Log", "UserName");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Workstation, newItem, "Common", "Log", "Workstation");

            /*DataStructureInfo WritableOrm ArgumentValidation Common.Log*/

            /*DataStructureInfo WritableOrm Initialization Common.Log*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_Log> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_Log> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            if (deletedIds.Count() > 0)
            {
                List<Common.LogRelatedItem> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.LogRelatedItem.Query()
                        .Where(child => child.LogID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.LogRelatedItem { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.LogRelatedItem.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Log*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Action == null || string.IsNullOrWhiteSpace(item.Action) /*RequiredPropertyInfo OrCondition Common.Log.Action*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Action" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Action", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Created == null /*RequiredPropertyInfo OrCondition Common.Log.Created*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Created" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Created", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.Log.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "UserName" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.Log.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Workstation" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Log*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.LogRelatedItem", @"LogID", @"FK_LogRelatedItem_Log_LogID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.Log*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.Log");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Log> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Log*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Log*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Log");

                /*DataStructureInfo WritableOrm AfterSave Common.Log*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Log*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Log*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogReader*/
    public class LogReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.ReadableRepositoryBase<Common.LogReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogReader*/

        public LogReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogReader*/
        }

        /*DataStructureInfo RepositoryMembers Common.LogReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItem*/
    public class LogRelatedItem_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItem*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.ReadableRepositoryBase<Common.LogRelatedItem> // global::Common.RepositoryBase
        , IWritableRepository<Common.LogRelatedItem>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.LogRelatedItem*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItem*/

        public LogRelatedItem_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItem*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItem*/
        }

        public virtual void Save(IEnumerable<Common.LogRelatedItem> insertedNew, IEnumerable<Common.LogRelatedItem> updatedNew, IEnumerable<Common.LogRelatedItem> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.LogRelatedItem*/

            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.LogRelatedItem" }, null, null);
            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Relation, newItem, "Common", "LogRelatedItem", "Relation");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.TableName, newItem, "Common", "LogRelatedItem", "TableName");

            /*DataStructureInfo WritableOrm ArgumentValidation Common.LogRelatedItem*/

            /*DataStructureInfo WritableOrm Initialization Common.LogRelatedItem*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_LogRelatedItem> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_LogRelatedItem> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.LogRelatedItem*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LogID == null /*RequiredPropertyInfo OrCondition Common.LogRelatedItem.Log*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.LogRelatedItem", "Log" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalid.ID.ToString() + ",Property:LogID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.LogRelatedItem*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Log", @"ID", @"FK_LogRelatedItem_Log_LogID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.LogRelatedItem*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.LogRelatedItem");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_LogRelatedItem> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.LogRelatedItem*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.LogRelatedItem*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.LogRelatedItem");

                /*DataStructureInfo WritableOrm AfterSave Common.LogRelatedItem*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredLog()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredLog(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.LogRelatedItem*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredLog(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredLog";
            metadata[@"Property"] = @"Log";
            /*InvalidDataInfo ErrorMetadata Common.LogRelatedItem.SystemRequiredLog*/
            /*InvalidDataInfo CustomValidationResult Common.LogRelatedItem.SystemRequiredLog*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Common.LogRelatedItem.Log" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Common_LogRelatedItem> Filter(IQueryable<Common.Queryable.Common_LogRelatedItem> source, Common.SystemRequiredLog parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.LogRelatedItem.'Common.SystemRequiredLog'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/
            
            return source.Where(item => item.Log == null);
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItem*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItemReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.ReadableRepositoryBase<Common.LogRelatedItemReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogRelatedItemReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItemReader*/

        public LogRelatedItemReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItemReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItemReader*/
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItemReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Principal*/
    public class Principal_Repository : /*DataStructureInfo OverrideBaseType Common.Principal*/ Common.OrmRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.QueryableRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.ReadableRepositoryBase<Common.Principal> // global::Common.RepositoryBase
        , IWritableRepository<Common.Principal>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Principal*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Principal*/

        public Principal_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Principal*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Principal*/
        }

        public virtual void Save(IEnumerable<Common.Principal> insertedNew, IEnumerable<Common.Principal> updatedNew, IEnumerable<Common.Principal> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Principal*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Name, newItem, "Common", "Principal", "Name");

            /*DataStructureInfo WritableOrm ArgumentValidation Common.Principal*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.Principal*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_Principal> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_Principal> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalHasRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalHasRole.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalHasRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalHasRole.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Principal*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Principal.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Principal", "Name" },
                        "DataStructure:Common.Principal,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Principal*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"PrincipalID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"PrincipalID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Principal", @"IX_Principal_Name"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Principal,Property:Name";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.Principal*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.Principal");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Principal> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalInfos = ((IEnumerable<Rhetos.Dom.DefaultConcepts.IPrincipal>)insertedNew).Concat(updatedNew)
                    .Concat(updatedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }))
                    .Concat(deletedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }));
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Principal*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Principal*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Principal");

                /*DataStructureInfo WritableOrm AfterSave Common.Principal*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Principal*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Principal*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalHasRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.ReadableRepositoryBase<Common.PrincipalHasRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalHasRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalHasRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalHasRole*/

        public PrincipalHasRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalHasRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalHasRole*/
        }

        public virtual void Save(IEnumerable<Common.PrincipalHasRole> insertedNew, IEnumerable<Common.PrincipalHasRole> updatedNew, IEnumerable<Common.PrincipalHasRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalHasRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalHasRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalHasRole*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_PrincipalHasRole> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalHasRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Principal" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Role" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalHasRole*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_PrincipalHasRole_Role_RoleID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalHasRole", @"IX_PrincipalHasRole_Principal_Role"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:Principal Role";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalHasRole*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.PrincipalHasRole");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalHasRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalHasRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalHasRole");

                /*DataStructureInfo WritableOrm AfterSave Common.PrincipalHasRole*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalHasRole*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalHasRole.SystemRequiredPrincipal*/
            /*InvalidDataInfo CustomValidationResult Common.PrincipalHasRole.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Common.PrincipalHasRole.Principal" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Filter(IQueryable<Common.Queryable.Common_PrincipalHasRole> source, Common.SystemRequiredPrincipal parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/
            
            return source.Where(item => item.Principal == null);
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Query(Rhetos.Dom.DefaultConcepts.IPrincipal queryParameter)
        {
            /*QueryExpressionInfo BeforeQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            Func<Rhetos.Dom.DefaultConcepts.IPrincipal, IQueryable<Common.Queryable.Common_PrincipalHasRole>> queryFunction = parameter => Query().Where(item => item.Principal.ID == parameter.ID);
            var queryResult = queryFunction(queryParameter);
            /*QueryExpressionInfo AfterQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            return queryResult;
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalHasRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalPermission*/
    public class PrincipalPermission_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalPermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.ReadableRepositoryBase<Common.PrincipalPermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalPermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalPermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalPermission*/

        public PrincipalPermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalPermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalPermission*/
        }

        public virtual void Save(IEnumerable<Common.PrincipalPermission> insertedNew, IEnumerable<Common.PrincipalPermission> updatedNew, IEnumerable<Common.PrincipalPermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalPermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalPermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalPermission*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_PrincipalPermission> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_PrincipalPermission> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalPermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Claim" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "IsAuthorized" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Principal" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalPermission*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_PrincipalPermission_Claim_ClaimID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalPermission", @"IX_PrincipalPermission_Principal_Claim"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:Principal Claim";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalPermission*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.PrincipalPermission");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalPermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalPermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalPermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalPermission");

                /*DataStructureInfo WritableOrm AfterSave Common.PrincipalPermission*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalPermission*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredClaim*/
            /*InvalidDataInfo CustomValidationResult Common.PrincipalPermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Claim" },
                Metadata = metadata
            });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredPrincipal*/
            /*InvalidDataInfo CustomValidationResult Common.PrincipalPermission.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Principal" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> source, Common.SystemRequiredClaim parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredClaim'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/
            
            return source.Where(item => item.Claim == null);
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> source, Common.SystemRequiredPrincipal parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/
            
            return source.Where(item => item.Principal == null);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalPermission*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource_Repository : /*DataStructureInfo OverrideBaseType Common.RelatedEventsSource*/ Common.OrmRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.QueryableRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.ReadableRepositoryBase<Common.RelatedEventsSource> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.RelatedEventsSource*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.RelatedEventsSource*/

        public RelatedEventsSource_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.RelatedEventsSource*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.RelatedEventsSource*/
        }

        /*DataStructureInfo RepositoryMembers Common.RelatedEventsSource*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ReleaseLock*/
    public class ReleaseLock_Repository : /*DataStructureInfo OverrideBaseType Common.ReleaseLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.ReleaseLock*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.ReleaseLock*/

        public ReleaseLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.ReleaseLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.ReleaseLock*/
        }

        public void Execute(Common.ReleaseLock actionParameter)
        {
            Action<Common.ReleaseLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.ReleaseLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var myLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID
                    && itemLock.UserName == userInfo.UserName
                    && itemLock.Workstation == userInfo.Workstation)
                .FirstOrDefault();

            if (myLock != null)
                repository.Common.ExclusiveLock.Delete(new[] { myLock });
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.ReleaseLock*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.ReleaseLock*/);
                /*ActionInfo AfterAction Common.ReleaseLock*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.ReleaseLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.ReleaseLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Role*/
    public class Role_Repository : /*DataStructureInfo OverrideBaseType Common.Role*/ Common.OrmRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.QueryableRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.ReadableRepositoryBase<Common.Role> // global::Common.RepositoryBase
        , IWritableRepository<Common.Role>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Role*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Role*/

        public Role_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Role*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Role*/
        }

        public virtual void Save(IEnumerable<Common.Role> insertedNew, IEnumerable<Common.Role> updatedNew, IEnumerable<Common.Role> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Role*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Name, newItem, "Common", "Role", "Name");

            /*DataStructureInfo WritableOrm ArgumentValidation Common.Role*/

            /*DataStructureInfo WritableOrm Initialization Common.Role*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_Role> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_Role> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            if (deletedIds.Count() > 0)
            {
                List<Common.RoleInheritsRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RoleInheritsRole.Query()
                        .Where(child => child.UsersFromID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RoleInheritsRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RoleInheritsRole.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.RoleID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Role*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Role.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Role", "Name" },
                        "DataStructure:Common.Role,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Role*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"RoleID", @"FK_PrincipalHasRole_Role_RoleID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"PermissionsFromID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"UsersFromID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"RoleID", @"FK_RolePermission_Role_RoleID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Role", @"IX_Role_Name"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Role,Property:Name";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.Role*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.Role");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Role> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Concat(deletedIds).Select(r => r.ID);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Role*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Role*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Role");

                /*DataStructureInfo WritableOrm AfterSave Common.Role*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Role*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Role*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole_Repository : /*DataStructureInfo OverrideBaseType Common.RoleInheritsRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.ReadableRepositoryBase<Common.RoleInheritsRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.RoleInheritsRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RoleInheritsRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RoleInheritsRole*/

        public RoleInheritsRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RoleInheritsRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RoleInheritsRole*/
        }

        public virtual void Save(IEnumerable<Common.RoleInheritsRole> insertedNew, IEnumerable<Common.RoleInheritsRole> updatedNew, IEnumerable<Common.RoleInheritsRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RoleInheritsRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RoleInheritsRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RoleInheritsRole*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_RoleInheritsRole> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RoleInheritsRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PermissionsFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.PermissionsFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "PermissionsFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:PermissionsFromID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UsersFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.UsersFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "UsersFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:UsersFromID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RoleInheritsRole*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RoleInheritsRole", @"IX_RoleInheritsRole_UsersFrom_PermissionsFrom"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFrom PermissionsFrom";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.RoleInheritsRole*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.RoleInheritsRole");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.UsersFromID)
                        .Concat(updatedOld.Select(item => item.UsersFromID))
                        .Concat(deletedOld.Select(item => item.UsersFromID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RoleInheritsRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RoleInheritsRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RoleInheritsRole");

                /*DataStructureInfo WritableOrm AfterSave Common.RoleInheritsRole*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredUsersFrom()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredUsersFrom(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RoleInheritsRole*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredUsersFrom(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredUsersFrom";
            metadata[@"Property"] = @"UsersFrom";
            /*InvalidDataInfo ErrorMetadata Common.RoleInheritsRole.SystemRequiredUsersFrom*/
            /*InvalidDataInfo CustomValidationResult Common.RoleInheritsRole.SystemRequiredUsersFrom*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Common.RoleInheritsRole.UsersFrom" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Common_RoleInheritsRole> Filter(IQueryable<Common.Queryable.Common_RoleInheritsRole> source, Common.SystemRequiredUsersFrom parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/
            
            return source.Where(item => item.UsersFrom == null);
        }

        /*DataStructureInfo RepositoryMembers Common.RoleInheritsRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RolePermission*/
    public class RolePermission_Repository : /*DataStructureInfo OverrideBaseType Common.RolePermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.ReadableRepositoryBase<Common.RolePermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.RolePermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RolePermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RolePermission*/

        public RolePermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RolePermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RolePermission*/
        }

        public virtual void Save(IEnumerable<Common.RolePermission> insertedNew, IEnumerable<Common.RolePermission> updatedNew, IEnumerable<Common.RolePermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RolePermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RolePermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RolePermission*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Common_RolePermission> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Common_RolePermission> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RolePermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Claim" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.RolePermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "IsAuthorized" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Role" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RolePermission*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_RolePermission_Claim_ClaimID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RolePermission_Role_RoleID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RolePermission", @"IX_RolePermission_Role_Claim"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:Role Claim";
                    /*DataStructureInfo WritableOrm OnDatabaseError Common.RolePermission*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Common.RolePermission");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RolePermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.RoleID)
                        .Concat(updatedOld.Select(item => item.RoleID))
                        .Concat(deletedOld.Select(item => item.RoleID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RolePermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RolePermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RolePermission");

                /*DataStructureInfo WritableOrm AfterSave Common.RolePermission*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredRole()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredRole(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RolePermission*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredClaim*/
            /*InvalidDataInfo CustomValidationResult Common.RolePermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Common.RolePermission.Claim" },
                Metadata = metadata
            });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredRole(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredRole";
            metadata[@"Property"] = @"Role";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredRole*/
            /*InvalidDataInfo CustomValidationResult Common.RolePermission.SystemRequiredRole*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Common.RolePermission.Role" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> source, Common.SystemRequiredClaim parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredClaim'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/
            
            return source.Where(item => item.Claim == null);
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> source, Common.SystemRequiredRole parameter)
        {/*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredRole'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/
            // /*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/
            
            return source.Where(item => item.Role == null);
        }

        /*DataStructureInfo RepositoryMembers Common.RolePermission*/
    }

    /*DataStructureInfo RepositoryAttributes Common.SetLock*/
    public class SetLock_Repository : /*DataStructureInfo OverrideBaseType Common.SetLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.SetLock*/
    {
        private readonly Rhetos.Utilities.ILocalizer _localizer;
        /*DataStructureInfo RepositoryPrivateMembers Common.SetLock*/

        public SetLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ILocalizer _localizer/*DataStructureInfo RepositoryConstructorArguments Common.SetLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._localizer = _localizer;
            /*DataStructureInfo RepositoryConstructorCode Common.SetLock*/
        }

        public void Execute(Common.SetLock actionParameter)
        {
            Action<Common.SetLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.SetLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

            var oldLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID)
                .FirstOrDefault();
            
            if (oldLock == null)
                repository.Common.ExclusiveLock.Insert(new[] { new Common.ExclusiveLock
                    {
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = now,
                        LockFinish = now.AddMinutes(15)
                    }});
            else if (oldLock.UserName == userInfo.UserName
                && oldLock.Workstation == userInfo.Workstation
                || oldLock.LockFinish < now)
                repository.Common.ExclusiveLock.Update(new[] { new Common.ExclusiveLock
                    {
                        ID = oldLock.ID,
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = now,
                        LockFinish = now.AddMinutes(15)
                    }});
             else
             {
                string lockInfo = _localizer["Locked record {0}, ID {1}.", oldLock.ResourceType, oldLock.ResourceID];

                string errorInfo;
                if (oldLock.UserName.Equals(userInfo.UserName, StringComparison.InvariantCultureIgnoreCase))
                    errorInfo = _localizer["It is not allowed to enter the record at client workstation '{0}' because the data entry is in progress at workstation '{1}'.",
                        userInfo.Workstation, oldLock.Workstation];
                else
                    errorInfo = _localizer["It is not allowed to enter the record because the data entry is in progress by user '{0}'.",
                        oldLock.UserName];
                
                string localizedMessage = errorInfo + "\r\n" + lockInfo;
                throw new Rhetos.UserException(localizedMessage);
             }
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.SetLock*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.SetLock*/);
                /*ActionInfo AfterAction Common.SetLock*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.SetLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.SetLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.MyClaim*/
    public class MyClaim_Repository : /*DataStructureInfo OverrideBaseType Common.MyClaim*/ Common.QueryableRepositoryBase<Common.Queryable.Common_MyClaim, Common.MyClaim> // Common.ReadableRepositoryBase<Common.MyClaim> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.MyClaim*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.MyClaim*/

        public MyClaim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.MyClaim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.MyClaim*/
        }

        public override IQueryable<Common.Queryable.Common_MyClaim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.MyClaim*/
            return Compute(_domRepository.Common.Claim.Query(), _domRepository/*DataStructureInfo AdditionalParametersArgument Common.MyClaim*/);
        }

        public readonly Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository/*DataStructureInfo AdditionalParametersType Common.MyClaim*/, IQueryable<Common.Queryable.Common_MyClaim>> Compute =
            (query, repository) =>
		{ throw new Rhetos.UserException("Reading Common.MyClaim without filter is not permitted. Use filter by Common.Claim or Common.Claim[]."); };

        public global::Common.MyClaim[] Load(Common.Claim filter_Parameter)
        {
            Func<Common.DomRepository, Common.Claim/*FilterByInfo AdditionalParametersType Common.MyClaim.'Common.Claim'*/, Common.MyClaim[]> filter_Function =
                (repository, parameter) =>
			{
				var claim = repository.Common.Claim.Query().Where(item => item.ClaimResource == parameter.ClaimResource && item.ClaimRight == parameter.ClaimRight).SingleOrDefault();
				if (claim == null)
					throw new Rhetos.UserException("Claim {0}-{1} does not exist.",
						new[] { parameter.ClaimResource, parameter.ClaimRight }, null, null);
				
				return repository.Common.MyClaim.Filter(new[] { claim });
			};

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'Common.Claim'*/);
        }

        public global::Common.MyClaim[] Load(IEnumerable<Common.Claim> filter_Parameter)
        {
            Func<Common.DomRepository, IEnumerable<Common.Claim>/*FilterByInfo AdditionalParametersType Common.MyClaim.'IEnumerable<Common.Claim>'*/, Common.MyClaim[]> filter_Function =
                (repository, claims) =>
			{
                var securityClaims = claims.Select(c => new Rhetos.Security.Claim(c.ClaimResource, c.ClaimRight)).ToList();
                var authorizations = _executionContext.AuthorizationManager.GetAuthorizations(securityClaims);
			
                return claims.Zip(authorizations, (claim, authorized) => new Common.MyClaim {
                        ID = claim.ID,
                        Applies = authorized
                    }).ToArray();
             };

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'IEnumerable<Common.Claim>'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.MyClaim*/
    }

    /*ModuleInfo HelperNamespaceMembers Common*/

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}

