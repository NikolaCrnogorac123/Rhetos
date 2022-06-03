﻿namespace Common
{
    using System;
    using Rhetos.Dom.DefaultConcepts;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class PersistenceStorageObjectMappings : IPersistenceStorageObjectMappings
    {
        Dictionary<Type, IPersistenceStorageObjectMapper> _mappings = new Dictionary<Type, IPersistenceStorageObjectMapper>();

        public PersistenceStorageObjectMappings()
        {
            _mappings.Add(typeof(Bookstore.Book), new Bookstore_Book_Mapper());
            _mappings.Add(typeof(Bookstore.BookTopic), new Bookstore_BookTopic_Mapper());
            _mappings.Add(typeof(Bookstore.ChildrensBook), new Bookstore_ChildrensBook_Mapper());
            _mappings.Add(typeof(Bookstore.Comment), new Bookstore_Comment_Mapper());
            _mappings.Add(typeof(Bookstore.Employee), new Bookstore_Employee_Mapper());
            _mappings.Add(typeof(Bookstore.ForeignBook), new Bookstore_ForeignBook_Mapper());
            _mappings.Add(typeof(Bookstore.Genre), new Bookstore_Genre_Mapper());
            _mappings.Add(typeof(Bookstore.Person), new Bookstore_Person_Mapper());
            _mappings.Add(typeof(Bookstore.Topic), new Bookstore_Topic_Mapper());
            _mappings.Add(typeof(Common.AutoCodeCache), new Common_AutoCodeCache_Mapper());
            _mappings.Add(typeof(Common.Claim), new Common_Claim_Mapper());
            _mappings.Add(typeof(Common.ExclusiveLock), new Common_ExclusiveLock_Mapper());
            _mappings.Add(typeof(Common.FilterId), new Common_FilterId_Mapper());
            _mappings.Add(typeof(Common.KeepSynchronizedMetadata), new Common_KeepSynchronizedMetadata_Mapper());
            _mappings.Add(typeof(Common.Log), new Common_Log_Mapper());
            _mappings.Add(typeof(Common.LogRelatedItem), new Common_LogRelatedItem_Mapper());
            _mappings.Add(typeof(Common.Principal), new Common_Principal_Mapper());
            _mappings.Add(typeof(Common.PrincipalHasRole), new Common_PrincipalHasRole_Mapper());
            _mappings.Add(typeof(Common.PrincipalPermission), new Common_PrincipalPermission_Mapper());
            _mappings.Add(typeof(Common.Role), new Common_Role_Mapper());
            _mappings.Add(typeof(Common.RoleInheritsRole), new Common_RoleInheritsRole_Mapper());
            _mappings.Add(typeof(Common.RolePermission), new Common_RolePermission_Mapper());
            /*PersistenceStorageMappingRegistration*/
        }

        public IPersistenceStorageObjectMapper GetMapping(Type type)
        {
            IPersistenceStorageObjectMapper mapper;
            if(_mappings.TryGetValue(type, out mapper))
                return mapper;
            else
                throw new Rhetos.FrameworkException($"There is no mapping associated with the type '{type}'. The mapping definition is required for database save operations.");
        }
    }

    public static class PersistenceStorageHelper
    {
        public static SqlParameter GetMoneySqlParameter(decimal? money)
        {
            // Simulates automatic rounding by Entity Framework, for backward compatibility. See related issue https://github.com/Rhetos/Rhetos/issues/389.
	        object dbValue = money != null ? (object)(((long)(money.Value * 100m)) / 100m) : DBNull.Value;
            return new SqlParameter("", System.Data.SqlDbType.Money) { Value = dbValue };
        }
    }

    public class Bookstore_Book_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.Book)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Active", new SqlParameter("", System.Data.SqlDbType.Bit) { Value = ((object)entity.Active) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("BookCreated", new SqlParameter("", System.Data.SqlDbType.DateTime) { Value = ((object)entity.BookCreated) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Code", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Code) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Modified", new SqlParameter("", System.Data.SqlDbType.DateTime) { Value = ((object)entity.Modified) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("NumberOfPages", new SqlParameter("", System.Data.SqlDbType.Int) { Value = ((object)entity.NumberOfPages) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Started", new SqlParameter("", System.Data.SqlDbType.DateTime) { Value = ((object)entity.Started) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Title", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Title) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("AuthorID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.AuthorID) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.Book*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.Book)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.Book*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.Book";
        }
    }

    public class Bookstore_BookTopic_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.BookTopic)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("BookID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.BookID) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("TopicID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.TopicID) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.BookTopic*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.BookTopic)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.BookTopic*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.BookTopic";
        }
    }

    public class Bookstore_ChildrensBook_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.ChildrensBook)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("AgeFrom", new SqlParameter("", System.Data.SqlDbType.Int) { Value = ((object)entity.AgeFrom) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("AgeTo", new SqlParameter("", System.Data.SqlDbType.Int) { Value = ((object)entity.AgeTo) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.ChildrensBook*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.ChildrensBook)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.ChildrensBook*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.ChildrensBook";
        }
    }

    public class Bookstore_Comment_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.Comment)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("BookID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.BookID) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Text", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Text) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.Comment*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.Comment)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.Comment*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.Comment";
        }
    }

    public class Bookstore_Employee_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.Employee)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("UserName", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.UserName) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.Employee*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.Employee)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.Employee*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.Employee";
        }
    }

    public class Bookstore_ForeignBook_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.ForeignBook)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("OriginalLanguage", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.OriginalLanguage) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("TranslatorID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.TranslatorID) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.ForeignBook*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.ForeignBook)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.ForeignBook*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.ForeignBook";
        }
    }

    public class Bookstore_Genre_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.Genre)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Description", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Description) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("IsFiction", new SqlParameter("", System.Data.SqlDbType.Bit) { Value = ((object)entity.IsFiction) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Label", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Label) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Name", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Name) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.Genre*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.Genre)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.Genre*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.Genre";
        }
    }

    public class Bookstore_Person_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.Person)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Name", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Name) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.Person*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.Person)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.Person*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.Person";
        }
    }

    public class Bookstore_Topic_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Bookstore.Topic)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Name", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Name) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Bookstore.Topic*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Bookstore.Topic)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Bookstore.Topic*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Bookstore.Topic";
        }
    }

    public class Common_AutoCodeCache_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.AutoCodeCache)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Entity", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Entity) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Grouping", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Grouping) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("LastCode", new SqlParameter("", System.Data.SqlDbType.Int) { Value = ((object)entity.LastCode) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("MinDigits", new SqlParameter("", System.Data.SqlDbType.Int) { Value = ((object)entity.MinDigits) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Prefix", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Prefix) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Property", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Property) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.AutoCodeCache*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.AutoCodeCache)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.AutoCodeCache*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.AutoCodeCache";
        }
    }

    public class Common_Claim_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.Claim)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Active", new SqlParameter("", System.Data.SqlDbType.Bit) { Value = ((object)entity.Active) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("ClaimResource", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.ClaimResource) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("ClaimRight", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.ClaimRight) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.Claim*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.Claim)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.Claim*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.Claim";
        }
    }

    public class Common_ExclusiveLock_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.ExclusiveLock)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("LockFinish", new SqlParameter("", System.Data.SqlDbType.DateTime) { Value = ((object)entity.LockFinish) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("LockStart", new SqlParameter("", System.Data.SqlDbType.DateTime) { Value = ((object)entity.LockStart) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("ResourceID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.ResourceID) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("ResourceType", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.ResourceType) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("UserName", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.UserName) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Workstation", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Workstation) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.ExclusiveLock*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.ExclusiveLock)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.ExclusiveLock*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.ExclusiveLock";
        }
    }

    public class Common_FilterId_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.FilterId)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Handle", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.Handle) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Value", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.Value) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.FilterId*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.FilterId)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.FilterId*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.FilterId";
        }
    }

    public class Common_KeepSynchronizedMetadata_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.KeepSynchronizedMetadata)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Context", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Context) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Source", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Source) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Target", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Target) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.KeepSynchronizedMetadata*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.KeepSynchronizedMetadata)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.KeepSynchronizedMetadata*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.KeepSynchronizedMetadata";
        }
    }

    public class Common_Log_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.Log)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Action", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Action) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("ContextInfo", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.ContextInfo) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Created", new SqlParameter("", System.Data.SqlDbType.DateTime) { Value = ((object)entity.Created) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Description", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Description) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("ItemId", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.ItemId) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("TableName", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.TableName) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("UserName", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.UserName) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Workstation", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Workstation) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.Log*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.Log)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.Log*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.Log";
        }
    }

    public class Common_LogRelatedItem_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.LogRelatedItem)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("ItemId", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.ItemId) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("LogID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.LogID) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("Relation", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Relation) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("TableName", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.TableName) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.LogRelatedItem*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.LogRelatedItem)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.LogRelatedItem*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.LogRelatedItem";
        }
    }

    public class Common_Principal_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.Principal)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Name", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Name) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.Principal*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.Principal)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.Principal*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.Principal";
        }
    }

    public class Common_PrincipalHasRole_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.PrincipalHasRole)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("PrincipalID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.PrincipalID) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("RoleID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.RoleID) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.PrincipalHasRole*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.PrincipalHasRole)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.PrincipalHasRole*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.PrincipalHasRole";
        }
    }

    public class Common_PrincipalPermission_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.PrincipalPermission)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("ClaimID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.ClaimID) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("IsAuthorized", new SqlParameter("", System.Data.SqlDbType.Bit) { Value = ((object)entity.IsAuthorized) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("PrincipalID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.PrincipalID) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.PrincipalPermission*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.PrincipalPermission)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.PrincipalPermission*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.PrincipalPermission";
        }
    }

    public class Common_Role_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.Role)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("Name", new SqlParameter("", System.Data.SqlDbType.NVarChar) { Value = ((object)entity.Name) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.Role*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.Role)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.Role*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.Role";
        }
    }

    public class Common_RoleInheritsRole_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.RoleInheritsRole)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("PermissionsFromID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.PermissionsFromID) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("UsersFromID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.UsersFromID) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.RoleInheritsRole*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.RoleInheritsRole)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.RoleInheritsRole*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.RoleInheritsRole";
        }
    }

    public class Common_RolePermission_Mapper : IPersistenceStorageObjectMapper
    {
        public PersistenceStorageObjectParameter[] GetParameters(IEntity genericEntity)
        {
            var entity = (Common.RolePermission)genericEntity;
            return new PersistenceStorageObjectParameter[]
            {
                new PersistenceStorageObjectParameter("ID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = entity.ID }),
                new PersistenceStorageObjectParameter("ClaimID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.ClaimID) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("IsAuthorized", new SqlParameter("", System.Data.SqlDbType.Bit) { Value = ((object)entity.IsAuthorized) ?? DBNull.Value }),
                new PersistenceStorageObjectParameter("RoleID", new SqlParameter("", System.Data.SqlDbType.UniqueIdentifier) { Value = ((object)entity.RoleID) ?? DBNull.Value }),
                /*DataStructureInfo PersistenceStorageMapperPropertyMapping Common.RolePermission*/
            };
        }
    
    	public IEnumerable<Guid> GetDependencies(IEntity genericEntity)
        {
            var entity = (Common.RolePermission)genericEntity;
            /*DataStructureInfo PersistenceStorageMapperDependencyResolution Common.RolePermission*/
            yield break;
        }
    
    	public string GetTableName()
        {
            return "Common.RolePermission";
        }
    }

    /*PersistenceStorageMappings*/
}
