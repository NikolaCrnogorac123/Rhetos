namespace Bookstore._Helper
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

    /*ModuleInfo Using Bookstore*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Book_Repository _Book_Repository;
        public Book_Repository Book { get { return _Book_Repository ?? (_Book_Repository = (Book_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Book")); } }

        private BookInfo_Repository _BookInfo_Repository;
        public BookInfo_Repository BookInfo { get { return _BookInfo_Repository ?? (_BookInfo_Repository = (BookInfo_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.BookInfo")); } }

        private BookTopic_Repository _BookTopic_Repository;
        public BookTopic_Repository BookTopic { get { return _BookTopic_Repository ?? (_BookTopic_Repository = (BookTopic_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.BookTopic")); } }

        private ChildrensBook_Repository _ChildrensBook_Repository;
        public ChildrensBook_Repository ChildrensBook { get { return _ChildrensBook_Repository ?? (_ChildrensBook_Repository = (ChildrensBook_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.ChildrensBook")); } }

        private Comment_Repository _Comment_Repository;
        public Comment_Repository Comment { get { return _Comment_Repository ?? (_Comment_Repository = (Comment_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Comment")); } }

        private Employee_Repository _Employee_Repository;
        public Employee_Repository Employee { get { return _Employee_Repository ?? (_Employee_Repository = (Employee_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Employee")); } }

        private ForeignBook_Repository _ForeignBook_Repository;
        public ForeignBook_Repository ForeignBook { get { return _ForeignBook_Repository ?? (_ForeignBook_Repository = (ForeignBook_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.ForeignBook")); } }

        private Genre_Repository _Genre_Repository;
        public Genre_Repository Genre { get { return _Genre_Repository ?? (_Genre_Repository = (Genre_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Genre")); } }

        private Insert5Books_Repository _Insert5Books_Repository;
        public Insert5Books_Repository Insert5Books { get { return _Insert5Books_Repository ?? (_Insert5Books_Repository = (Insert5Books_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Insert5Books")); } }

        private InsertManyBooks_Repository _InsertManyBooks_Repository;
        public InsertManyBooks_Repository InsertManyBooks { get { return _InsertManyBooks_Repository ?? (_InsertManyBooks_Repository = (InsertManyBooks_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.InsertManyBooks")); } }

        private Person_Repository _Person_Repository;
        public Person_Repository Person { get { return _Person_Repository ?? (_Person_Repository = (Person_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Person")); } }

        private Topic_Repository _Topic_Repository;
        public Topic_Repository Topic { get { return _Topic_Repository ?? (_Topic_Repository = (Topic_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Topic")); } }

        private BookStoreGrid_Repository _BookStoreGrid_Repository;
        public BookStoreGrid_Repository BookStoreGrid { get { return _BookStoreGrid_Repository ?? (_BookStoreGrid_Repository = (BookStoreGrid_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.BookStoreGrid")); } }

        /*ModuleInfo RepositoryMembers Bookstore*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Book*/
    public class Book_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Book*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Book, Bookstore.Book> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Book, Bookstore.Book> // Common.ReadableRepositoryBase<Bookstore.Book> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Book>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Book*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Book*/

        public Book_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Book*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Book*/
        }

        public virtual void Save(IEnumerable<Bookstore.Book> insertedNew, IEnumerable<Bookstore.Book> updatedNew, IEnumerable<Bookstore.Book> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Book*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Code, newItem, "Bookstore", "Book", "Code");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Title, newItem, "Bookstore", "Book", "Title");

            if (checkUserPermissions)
            {
                var invalidItem = insertedNew.Where(newItem => newItem.Started != null).FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "Started", "Bookstore.Book" },
                        "DataStructure:Bookstore.Book,ID:" + invalidItem.ID + ",Property:Started",
                        null);
            
            }

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Book*/

            InitializeDefaultValues(insertedNew);

            { 
                var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

                foreach (var newItem in insertedNew)
                    if(newItem.Started == null)
                        newItem.Started = now;
            }
            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                Title = item.Title/*LoadOldItemsInfo SelectProperties Bookstore.Book*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                Title = item.Title/*LoadOldItemsInfo SelectProperties Bookstore.Book*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Bookstore.Book*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_Book> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_Book> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            DeactivatableCodeGenerator.SetActiveByDefault(insertedNew, updatedNew, updated);

            if (updatedNew.Count() > 0 || deletedIds.Count() > 0)
            {
                Bookstore.Book[] changedItems = updated.Concat(deleted).ToArray();

                var lockedItems = _domRepository.Bookstore.Book.Filter(this.Query(changedItems.Select(item => item.ID)), new ContainsLockMark());
                if (lockedItems.Count() > 0)
                    throw new Rhetos.UserException(@"[Test] Title contains lock mark", "DataStructure:Bookstore.Book,ID:" + lockedItems.First().ID.ToString()/*LockItemsInfo ClientMessage Bookstore.Book.ContainsLockMark*/);
            }
            {
                var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);
                foreach (var newItem in insertedNew)
                {
                    if(newItem.Modified == null)
                        newItem.Modified = now;
                    /*ModificationTimeOfInfrastructureInfo PropertyInitialization Bookstore.Book*/
                }

                bool updateModificationTime = true;
                while (updateModificationTime)
                {
                    updateModificationTime = false;
                    {
                        var modifiedItems = updatedOld
					        .Zip(updatedNew, (oldValue, newValue) => new { oldValue, newValue })
					        .Where(modified => modified.oldValue.Title == null && modified.newValue.Title != null
                                || modified.oldValue.Title != null && !modified.oldValue.Title.Equals(modified.newValue.Title));

                        foreach (var modified in modifiedItems)
                            if (modified.newValue.Modified != now)
                            {
                                modified.newValue.Modified = now;
                                updateModificationTime = true;
                            }
                    }
                    /*ModificationTimeOfInfrastructureInfo UpdateModified Bookstore.Book*/
                }
            }

            AutoCodeHelper.UpdateCodesWithoutCache(
                _executionContext.SqlExecuter, "Bookstore.Book", "Code",
                insertedNew.Select(item => AutoCodeItem.Create(item, item.Code/*AutoCodePropertyInfo Grouping Bookstore.Book.Code*/)).ToList(),
                (item, newCode) => item.Code = newCode/*AutoCodePropertyInfo GroupColumnMetadata Bookstore.Book.Code*/);

            if (checkUserPermissions)
            {
                var changes = updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem });
                foreach (var change in changes)
                    if (change.newItem.Started == null && change.oldItem.Started != null)
                        change.newItem.Started = change.oldItem.Started;
                var invalidItem = changes
                    .Where(change => change.newItem.Started != null && !change.newItem.Started.Equals(change.oldItem.Started) || change.newItem.Started == null && change.oldItem.Started != null)
                    .Select(change => change.newItem)
                    .FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "Started", "Bookstore.Book" },
                        "DataStructure:Bookstore.Book,ID:" + invalidItem.ID + ",Property:Started",
                        null);
            
            }

            if (deletedIds.Count() > 0)
            {
                List<Bookstore.BookTopic> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Bookstore.BookTopic.Query()
                        .Where(child => child.BookID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Bookstore.BookTopic { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Bookstore.BookTopic.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Bookstore.ChildrensBook> childItems = _executionContext.Repository.Bookstore.ChildrensBook
                    .Query(deletedIds.Select(parent => parent.ID))
                    .Select(child => child.ID).ToList()
                    .Select(childId => new Bookstore.ChildrensBook { ID = childId }).ToList();

                if (childItems.Count() > 0)
                    _domRepository.Bookstore.ChildrensBook.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Bookstore.Comment> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Bookstore.Comment.Query()
                        .Where(child => child.BookID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Bookstore.Comment { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Bookstore.Comment.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Bookstore.ForeignBook> childItems = _executionContext.Repository.Bookstore.ForeignBook
                    .Query(deletedIds.Select(parent => parent.ID))
                    .Select(child => child.ID).ToList()
                    .Select(childId => new Bookstore.ForeignBook { ID = childId }).ToList();

                if (childItems.Count() > 0)
                    _domRepository.Bookstore.ForeignBook.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Book*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Book*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.BookTopic", @"BookID", @"FK_BookTopic_Book_BookID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTopic,Property:BookID,Referenced:Bookstore.Book";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.ChildrensBook", @"ID", @"FK_ChildrensBook_Book_ID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.ChildrensBook,Property:ID,Referenced:Bookstore.Book";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.Comment", @"BookID", @"FK_Comment_Book_BookID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Comment,Property:BookID,Referenced:Bookstore.Book";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.ForeignBook", @"ID", @"FK_ForeignBook_Book_ID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.ForeignBook,Property:ID,Referenced:Bookstore.Book";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Person", @"ID", @"FK_Book_Person_AuthorID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Book,Property:AuthorID,Referenced:Bookstore.Person";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Bookstore.Book", @"IX_Book_Code"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Book,Property:Code";
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Book*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.Book");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Book> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Book*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Book*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Book");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Book*/

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
                var errorIds = this.Filter(this.Query(ids), new CommonMisspelling()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_CommonMisspelling(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new LongBooks()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_LongBooks(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new ShortBooks()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_ShortBooks(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredActive()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredActive(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCode()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCode(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Book*/
            yield break;
        }

        public void InitializeDefaultValues(IEnumerable<global::Bookstore.Book> items)
        {
            /*DefaultValuesInfo BeforeDefaultValues Bookstore.Book*/
            foreach (var item in items)
            {
                if (item.BookCreated == null /*DefaultValueInfo DefaultValueAndCondition Bookstore.Book.BookCreated*/)
                    item.BookCreated = DefaultValue_BookCreated(item);
                /*DefaultValuesInfo SetDefaultValue Bookstore.Book*/
            }
            /*DefaultValuesInfo AfterDefaultValues Bookstore.Book*/
        }

        public global::Bookstore.Book[] Load(ComplexSearch filter_Parameter)
        {
            Func<Common.DomRepository, ComplexSearch/*FilterByInfo AdditionalParametersType Bookstore.Book.ComplexSearch*/, Bookstore.Book[]> filter_Function =
                (repository, parameter) =>
        {
            var query = repository.Bookstore.Book.Query(item => item.NumberOfPages >= parameter.MinimumPages);
            if (parameter.ForeignBooksOnly == true)
                query = query.Where(item => item.Extension_ForeignBook.ID != null);
            Book[] books = query.ToSimple().ToArray();

            if (parameter.MaskTitles == true)
                foreach (var book in books.Where(b => !string.IsNullOrEmpty(b.Title)))
                    book.Title = book.Title.First() + "***" + book.Title.Last();

            return books;
        };

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Bookstore.Book.ComplexSearch*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_CommonMisspelling(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"CommonMisspelling";
            /*InvalidDataInfo ErrorMetadata Bookstore.Book.CommonMisspelling*/
            /*InvalidDataInfo CustomValidationResult Bookstore.Book.CommonMisspelling*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"It is not allowed to enter misspelled word ""curiousity"".",
                Metadata = metadata
            });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_LongBooks(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"LongBooks";
            /*InvalidDataInfo ErrorMetadata Bookstore.Book.LongBooks*/
            /*InvalidDataInfo CustomValidationResult Bookstore.Book.LongBooks*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"It is not allowed to enter books with more pages than 500",
                Metadata = metadata
            });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_ShortBooks(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"ShortBooks";
            /*InvalidDataInfo ErrorMetadata Bookstore.Book.ShortBooks*/
            /*InvalidDataInfo CustomValidationResult Bookstore.Book.ShortBooks*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"It is not allowed to have a book with 0 or less pages",
                Metadata = metadata
            });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredActive(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredActive";
            metadata[@"Property"] = @"Active";
            /*InvalidDataInfo ErrorMetadata Bookstore.Book.SystemRequiredActive*/
            /*InvalidDataInfo CustomValidationResult Bookstore.Book.SystemRequiredActive*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Bool Bookstore.Book.Active" },
                Metadata = metadata
            });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCode(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCode";
            metadata[@"Property"] = @"Code";
            /*InvalidDataInfo ErrorMetadata Bookstore.Book.SystemRequiredCode*/
            /*InvalidDataInfo CustomValidationResult Bookstore.Book.SystemRequiredCode*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"ShortString Bookstore.Book.Code" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> query, AverageBooks parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.AverageBooks*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.AverageBooks*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.AverageBooks*/
            
            return query.Where(item=>item.NumberOfPages>=parameter.MinimumPages && item.NumberOfPages<=parameter.MaximumPages);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> source, Bookstore.CommonMisspelling parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.CommonMisspelling'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.CommonMisspelling'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.CommonMisspelling'*/
            
            return source.Where(book => book.Title.Contains("curiousity"));
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> source, Bookstore.ContainsLockMark parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.ContainsLockMark'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.ContainsLockMark'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.ContainsLockMark'*/
            
            return source.Where(item => item.Title.Contains("lock"));
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> source, Bookstore.LongBooks parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.LongBooks'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.LongBooks'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.LongBooks'*/
            
            return source.Where(item => item.NumberOfPages >= 500);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> source, Bookstore.ShortBooks parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.ShortBooks'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.ShortBooks'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.ShortBooks'*/
            
            return source.Where(item=>item.NumberOfPages <= 0);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> source, Bookstore.SystemRequiredActive parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.SystemRequiredActive'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.SystemRequiredActive'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.SystemRequiredActive'*/
            
            return source.Where(item => item.Active == null);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> source, Bookstore.SystemRequiredCode parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.SystemRequiredCode'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.SystemRequiredCode'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.SystemRequiredCode'*/
            
            return source.Where(item => item.Code == null);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> query, LongBooks3 parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.LongBooks3*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.LongBooks3*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.LongBooks3*/
            
            var filtered = query.Where(item => item.NumberOfPages >= parameter.MinimumPages);
                if (parameter.ForeignBooksOnly == true)
                    filtered = filtered.Where(item => item.Extension_ForeignBook.ID != null);
                return filtered;
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> items, Rhetos.Dom.DefaultConcepts.ActiveItems parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            
            if (parameter != null && parameter.ItemID.HasValue)
                            return items.Where(item => item.Active == null || item.Active.Value || item.ID == parameter.ItemID.Value);
                        else
                            return items.Where(item => item.Active == null || item.Active.Value);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> query, ShortBooks2 parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Book.ShortBooks2*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.ShortBooks2*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.ShortBooks2*/
            
            return query.Where(item=>item.NumberOfPages<=100);
        }

        private DateTime? DefaultValue_BookCreated(Bookstore.Book item)
        {
            return DateTime.Now.Date;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Book*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.BookInfo*/
    public class BookInfo_Repository : /*DataStructureInfo OverrideBaseType Bookstore.BookInfo*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_BookInfo, Bookstore.BookInfo> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_BookInfo, Bookstore.BookInfo> // Common.ReadableRepositoryBase<Bookstore.BookInfo> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Bookstore.BookInfo*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.BookInfo*/

        public BookInfo_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Bookstore.BookInfo*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.BookInfo*/
        }

        /*DataStructureInfo RepositoryMembers Bookstore.BookInfo*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.BookTopic*/
    public class BookTopic_Repository : /*DataStructureInfo OverrideBaseType Bookstore.BookTopic*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_BookTopic, Bookstore.BookTopic> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_BookTopic, Bookstore.BookTopic> // Common.ReadableRepositoryBase<Bookstore.BookTopic> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.BookTopic>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.BookTopic*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.BookTopic*/

        public BookTopic_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.BookTopic*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.BookTopic*/
        }

        public virtual void Save(IEnumerable<Bookstore.BookTopic> insertedNew, IEnumerable<Bookstore.BookTopic> updatedNew, IEnumerable<Bookstore.BookTopic> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.BookTopic*/

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.BookTopic*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.BookTopic*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_BookTopic> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_BookTopic> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.BookTopic*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.TopicID == null /*RequiredPropertyInfo OrCondition Bookstore.BookTopic.Topic*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Bookstore.BookTopic", "Topic" },
                        "DataStructure:Bookstore.BookTopic,ID:" + invalid.ID.ToString() + ",Property:TopicID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.BookTopic*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Book", @"ID", @"FK_BookTopic_Book_BookID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTopic,Property:BookID,Referenced:Bookstore.Book";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Topic", @"ID", @"FK_BookTopic_Topic_TopicID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTopic,Property:TopicID,Referenced:Bookstore.Topic";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Bookstore.BookTopic", @"IX_BookTopic_Book_Topic"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTopic,Property:Book Topic";
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.BookTopic*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.BookTopic");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_BookTopic> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.BookTopic*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.BookTopic*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.BookTopic");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.BookTopic*/

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
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredBook()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredBook(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.BookTopic*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredBook(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredBook";
            metadata[@"Property"] = @"Book";
            /*InvalidDataInfo ErrorMetadata Bookstore.BookTopic.SystemRequiredBook*/
            /*InvalidDataInfo CustomValidationResult Bookstore.BookTopic.SystemRequiredBook*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Bookstore.BookTopic.Book" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Bookstore_BookTopic> Filter(IQueryable<Common.Queryable.Bookstore_BookTopic> source, Bookstore.SystemRequiredBook parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.BookTopic.'Bookstore.SystemRequiredBook'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.BookTopic.'Bookstore.SystemRequiredBook'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.BookTopic.'Bookstore.SystemRequiredBook'*/
            
            return source.Where(item => item.Book == null);
        }

        /*DataStructureInfo RepositoryMembers Bookstore.BookTopic*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.ChildrensBook*/
    public class ChildrensBook_Repository : /*DataStructureInfo OverrideBaseType Bookstore.ChildrensBook*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_ChildrensBook, Bookstore.ChildrensBook> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_ChildrensBook, Bookstore.ChildrensBook> // Common.ReadableRepositoryBase<Bookstore.ChildrensBook> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.ChildrensBook>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.ChildrensBook*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.ChildrensBook*/

        public ChildrensBook_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.ChildrensBook*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.ChildrensBook*/
        }

        public virtual void Save(IEnumerable<Bookstore.ChildrensBook> insertedNew, IEnumerable<Bookstore.ChildrensBook> updatedNew, IEnumerable<Bookstore.ChildrensBook> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.ChildrensBook*/

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.ChildrensBook*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.ChildrensBook*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_ChildrensBook> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_ChildrensBook> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.ChildrensBook*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.ChildrensBook*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.ChildrensBook*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.ChildrensBook");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_ChildrensBook> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.ChildrensBook*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.ChildrensBook*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.ChildrensBook");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.ChildrensBook*/

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
                var errorIds = this.Filter(this.Query(ids), new AgeFrom_AgeTo_RangeFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_AgeFrom__AgeTo__RangeFilter(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.ChildrensBook*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_AgeFrom__AgeTo__RangeFilter(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"AgeFrom_AgeTo_RangeFilter";
            metadata[@"Property"] = @"AgeFrom";
            /*InvalidDataInfo ErrorMetadata Bookstore.ChildrensBook.AgeFrom_AgeTo_RangeFilter*/
            /*InvalidDataInfo CustomValidationResult Bookstore.ChildrensBook.AgeFrom_AgeTo_RangeFilter*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"Value of {0} has to be less than or equal to {1}.",
                MessageParameters = new object[] { @"AgeFrom", @"AgeTo" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Bookstore_ChildrensBook> Filter(IQueryable<Common.Queryable.Bookstore_ChildrensBook> source, Bookstore.AgeFrom_AgeTo_RangeFilter parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.ChildrensBook.'Bookstore.AgeFrom_AgeTo_RangeFilter'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.ChildrensBook.'Bookstore.AgeFrom_AgeTo_RangeFilter'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.ChildrensBook.'Bookstore.AgeFrom_AgeTo_RangeFilter'*/
            
            return source.Where(item => item.AgeFrom != null && item.AgeTo != null && item.AgeFrom > item.AgeTo);
        }

        /*DataStructureInfo RepositoryMembers Bookstore.ChildrensBook*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Comment*/
    public class Comment_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Comment*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Comment, Bookstore.Comment> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Comment, Bookstore.Comment> // Common.ReadableRepositoryBase<Bookstore.Comment> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Comment>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Comment*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Comment*/

        public Comment_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Comment*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Comment*/
        }

        public virtual void Save(IEnumerable<Bookstore.Comment> insertedNew, IEnumerable<Bookstore.Comment> updatedNew, IEnumerable<Bookstore.Comment> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Comment*/

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Comment*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.Comment*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_Comment> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_Comment> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Comment*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Comment*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Book", @"ID", @"FK_Comment_Book_BookID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Comment,Property:BookID,Referenced:Bookstore.Book";
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Comment*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.Comment");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Comment> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Comment*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Comment*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Comment");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Comment*/

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
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredBook()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredBook(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Comment*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredBook(IEnumerable<Guid> invalidData_Ids)
        {
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredBook";
            metadata[@"Property"] = @"Book";
            /*InvalidDataInfo ErrorMetadata Bookstore.Comment.SystemRequiredBook*/
            /*InvalidDataInfo CustomValidationResult Bookstore.Comment.SystemRequiredBook*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = @"System required property {0} is not set.",
                MessageParameters = new object[] { @"Reference Bookstore.Comment.Book" },
                Metadata = metadata
            });
        }

        public IQueryable<Common.Queryable.Bookstore_Comment> Filter(IQueryable<Common.Queryable.Bookstore_Comment> source, Bookstore.SystemRequiredBook parameter)
        {/*ComposableFilterByInfo BeforeFilter Bookstore.Comment.'Bookstore.SystemRequiredBook'*/
            // Suppressing additional expression arguments in optimized ComposableFilterBy format (configuration option CommonConcepts:ComposableFilterByOptimizeLambda)
            // /*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Comment.'Bookstore.SystemRequiredBook'*/
            // /*ComposableFilterByInfo AdditionalParametersType Bookstore.Comment.'Bookstore.SystemRequiredBook'*/
            
            return source.Where(item => item.Book == null);
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Comment*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Employee*/
    public class Employee_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Employee*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Employee, Bookstore.Employee> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Employee, Bookstore.Employee> // Common.ReadableRepositoryBase<Bookstore.Employee> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Employee>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Employee*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Employee*/

        public Employee_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Employee*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Employee*/
        }

        public virtual void Save(IEnumerable<Bookstore.Employee> insertedNew, IEnumerable<Bookstore.Employee> updatedNew, IEnumerable<Bookstore.Employee> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Employee*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.UserName, newItem, "Bookstore", "Employee", "UserName");

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Employee*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.Employee*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_Employee> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_Employee> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Employee*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Employee*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Employee*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.Employee");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Employee> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Employee*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Employee*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Employee");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Employee*/

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
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Employee*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Employee*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.ForeignBook*/
    public class ForeignBook_Repository : /*DataStructureInfo OverrideBaseType Bookstore.ForeignBook*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_ForeignBook, Bookstore.ForeignBook> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_ForeignBook, Bookstore.ForeignBook> // Common.ReadableRepositoryBase<Bookstore.ForeignBook> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.ForeignBook>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.ForeignBook*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.ForeignBook*/

        public ForeignBook_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.ForeignBook*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.ForeignBook*/
        }

        public virtual void Save(IEnumerable<Bookstore.ForeignBook> insertedNew, IEnumerable<Bookstore.ForeignBook> updatedNew, IEnumerable<Bookstore.ForeignBook> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.ForeignBook*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.OriginalLanguage, newItem, "Bookstore", "ForeignBook", "OriginalLanguage");

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.ForeignBook*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.ForeignBook*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_ForeignBook> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_ForeignBook> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.ForeignBook*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.ForeignBook*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Person", @"ID", @"FK_ForeignBook_Person_TranslatorID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.ForeignBook,Property:TranslatorID,Referenced:Bookstore.Person";
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.ForeignBook*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.ForeignBook");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_ForeignBook> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.ForeignBook*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.ForeignBook*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.ForeignBook");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.ForeignBook*/

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
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.ForeignBook*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.ForeignBook*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Genre*/
    public class Genre_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Genre*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Genre, Bookstore.Genre> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Genre, Bookstore.Genre> // Common.ReadableRepositoryBase<Bookstore.Genre> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Genre>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Genre*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Genre*/

        public Genre_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Genre*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Genre*/
        }

        public virtual void Save(IEnumerable<Bookstore.Genre> insertedNew, IEnumerable<Bookstore.Genre> updatedNew, IEnumerable<Bookstore.Genre> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Genre*/

            throw new Rhetos.UserException("It is not allowed to modify hard-coded data in {0}.", new []{"Bookstore.Genre"}, null, null);
            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Label, newItem, "Bookstore", "Genre", "Label");

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Name, newItem, "Bookstore", "Genre", "Name");

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Genre*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.Genre*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_Genre> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_Genre> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Genre*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Genre*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Genre*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.Genre");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Genre> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Genre*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Genre*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Genre");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Genre*/

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
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Genre*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Genre*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Insert5Books*/
    public class Insert5Books_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Insert5Books*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Bookstore.Insert5Books*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Insert5Books*/

        public Insert5Books_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Bookstore.Insert5Books*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Insert5Books*/
        }

        public void Execute(Bookstore.Insert5Books actionParameter)
        {
            Action<Bookstore.Insert5Books, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Bookstore.Insert5Books*/> action_Object = (parameter, repository, userInfo) =>
        {
            for (int i = 0; i < 5; i++)
            {
                var newBook = new Bookstore.Book { Code = "+++", Title = "Book"+i };
                repository.Bookstore.Book.Insert(newBook);
            }
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Bookstore.Insert5Books*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Bookstore.Insert5Books*/);
                /*ActionInfo AfterAction Bookstore.Insert5Books*/
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
            Execute((Bookstore.Insert5Books) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Insert5Books*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.InsertManyBooks*/
    public class InsertManyBooks_Repository : /*DataStructureInfo OverrideBaseType Bookstore.InsertManyBooks*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Bookstore.InsertManyBooks*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.InsertManyBooks*/

        public InsertManyBooks_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Bookstore.InsertManyBooks*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.InsertManyBooks*/
        }

        public void Execute(Bookstore.InsertManyBooks actionParameter)
        {
            Action<Bookstore.InsertManyBooks, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Bookstore.InsertManyBooks*/> action_Object = (parameter, repository, userInfo) =>
    {
        for (int i = 0; i < parameter.NumberOfBooks; i++)
        {
            string newTitle = parameter.TitlePrefix + " - " + (i + 1);
            var newBook = new Bookstore.Book { Code = "+++", Title = newTitle };
            repository.Bookstore.Book.Insert(newBook);
        }
    };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Bookstore.InsertManyBooks*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Bookstore.InsertManyBooks*/);
                /*ActionInfo AfterAction Bookstore.InsertManyBooks*/
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
            Execute((Bookstore.InsertManyBooks) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Bookstore.InsertManyBooks*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Person*/
    public class Person_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Person*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Person, Bookstore.Person> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Person, Bookstore.Person> // Common.ReadableRepositoryBase<Bookstore.Person> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Person>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Person*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Person*/

        public Person_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Person*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Person*/
        }

        public virtual void Save(IEnumerable<Bookstore.Person> insertedNew, IEnumerable<Bookstore.Person> updatedNew, IEnumerable<Bookstore.Person> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Person*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Name, newItem, "Bookstore", "Person", "Name");

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Person*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.Person*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_Person> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_Person> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Person*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Person*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.Book", @"AuthorID", @"FK_Book_Person_AuthorID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Book,Property:AuthorID,Referenced:Bookstore.Person";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.ForeignBook", @"TranslatorID", @"FK_ForeignBook_Person_TranslatorID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.ForeignBook,Property:TranslatorID,Referenced:Bookstore.Person";
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Person*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.Person");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Person> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Person*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Person*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Person");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Person*/

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
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Person*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Person*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Topic*/
    public class Topic_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Topic*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Topic, Bookstore.Topic> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Topic, Bookstore.Topic> // Common.ReadableRepositoryBase<Bookstore.Topic> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Topic>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Topic*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Topic*/

        public Topic_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Topic*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Topic*/
        }

        public virtual void Save(IEnumerable<Bookstore.Topic> insertedNew, IEnumerable<Bookstore.Topic> updatedNew, IEnumerable<Bookstore.Topic> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.InitializeSaveMethodItems(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Topic*/

            foreach (var newItem in insertedNew.Concat(updatedNew))
                ShortStringPropertyCodeGenerator.CheckMaxLength(newItem.Name, newItem, "Bookstore", "Topic", "Name");

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Topic*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.Topic*/

            // Using old data, including lazy loading of navigation properties:

            IEnumerable<Common.Queryable.Bookstore_Topic> deleted = DomHelper.LoadOldDataWithNavigationProperties(deletedIds, this);
            IEnumerable<Common.Queryable.Bookstore_Topic> updated = DomHelper.LoadOldDataWithNavigationProperties(updatedNew, this);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Topic*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Bookstore.Topic.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Bookstore.Topic", "Name" },
                        "DataStructure:Bookstore.Topic,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Topic*/

            {
                DomHelper.WriteToDatabase(insertedNew, updatedNew, deletedIds, _executionContext.PersistenceStorage, checkUserPermissions, _sqlUtility,
                    out Exception saveException, out Rhetos.RhetosException interpretedException);

                if (saveException != null)
                {
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.BookTopic", @"TopicID", @"FK_BookTopic_Topic_TopicID"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTopic,Property:TopicID,Referenced:Bookstore.Topic";
                    if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Bookstore.Topic", @"IX_Topic_Name"))
                        ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Topic,Property:Name";
                    /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Topic*/
                    DomHelper.ThrowInterpretedException(checkUserPermissions, saveException, interpretedException, _sqlUtility, "Bookstore.Topic");
                }
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Topic> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Topic*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Topic*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Topic");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Topic*/

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
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Topic*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Topic*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.BookStoreGrid*/
    public class BookStoreGrid_Repository : /*DataStructureInfo OverrideBaseType Bookstore.BookStoreGrid*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_BookStoreGrid, Bookstore.BookStoreGrid> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_BookStoreGrid, Bookstore.BookStoreGrid> // Common.ReadableRepositoryBase<Bookstore.BookStoreGrid> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Bookstore.BookStoreGrid*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.BookStoreGrid*/

        public BookStoreGrid_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Bookstore.BookStoreGrid*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.BookStoreGrid*/
        }

        public override IQueryable<Common.Queryable.Bookstore_BookStoreGrid> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.BookStoreGrid*/
            return Query(_domRepository.Bookstore.Book.Query());
        }

        public IQueryable<Common.Queryable.Bookstore_BookStoreGrid> Query(IQueryable<Common.Queryable.Bookstore_Book> source)
        {
            return source.Select(item => new Common.Queryable.Bookstore_BookStoreGrid
                {
                    ID = item.ID,
                    Base = item,
                    AuthorName = item.Author.Name,
                    NumberOfTopics = item.Extension_BookInfo.NumberOfComments,
                    Title = item.Title,
                    /*BrowseDataStructureInfo BrowseProperties Bookstore.BookStoreGrid*/
                });
        }

        /*DataStructureInfo RepositoryMembers Bookstore.BookStoreGrid*/
    }

    /*ModuleInfo HelperNamespaceMembers Bookstore*/

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}

