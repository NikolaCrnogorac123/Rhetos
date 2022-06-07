namespace Bookstore
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

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.AgeFrom_AgeTo_RangeFilter*/
    public class AgeFrom_AgeTo_RangeFilter/*DataStructureInfo ClassInterace Bookstore.AgeFrom_AgeTo_RangeFilter*/
    {
        /*DataStructureInfo ClassBody Bookstore.AgeFrom_AgeTo_RangeFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.AverageBooks*/
    public class AverageBooks/*DataStructureInfo ClassInterace Bookstore.AverageBooks*/
    {
        [DataMember]/*PropertyInfo Attribute Bookstore.AverageBooks.MaximumPages*/
        public int? MaximumPages { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.AverageBooks.MinimumPages*/
        public int? MinimumPages { get; set; }
        /*DataStructureInfo ClassBody Bookstore.AverageBooks*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Book*/
    public class Book : EntityBase<Bookstore.Book>, Rhetos.Dom.DefaultConcepts.IDeactivatable/*Next DataStructureInfo ClassInterace Bookstore.Book*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Book ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Book
            {
                ID = item.ID,
                Active = item.Active,
                BookCreated = item.BookCreated,
                Code = item.Code,
                Modified = item.Modified,
                NumberOfPages = item.NumberOfPages,
                Started = item.Started,
                Title = item.Title,
                AuthorID = item.AuthorID/*DataStructureInfo AssignSimpleProperty Bookstore.Book*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.Book.Active*/
        public bool? Active { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.BookCreated*/
        public DateTime? BookCreated { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.Code*/
        public string Code { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.Modified*/
        public DateTime? Modified { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.NumberOfPages*/
        public int? NumberOfPages { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.Started*/
        public DateTime? Started { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.Title*/
        public string Title { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.AuthorID*/
        public Guid? AuthorID { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Book*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.BookInfo*/
    public class BookInfo : EntityBase<Bookstore.BookInfo>/*Next DataStructureInfo ClassInterace Bookstore.BookInfo*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_BookInfo ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_BookInfo
            {
                ID = item.ID,
                NumberOfComments = item.NumberOfComments/*DataStructureInfo AssignSimpleProperty Bookstore.BookInfo*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.BookInfo.NumberOfComments*/
        public int? NumberOfComments { get; set; }
        /*DataStructureInfo ClassBody Bookstore.BookInfo*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.BooksWithTopics*/
    public class BooksWithTopics : EntityBase<Bookstore.BooksWithTopics>/*Next DataStructureInfo ClassInterace Bookstore.BooksWithTopics*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_BooksWithTopics ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_BooksWithTopics
            {
                ID = item.ID,
                NumberOfTopics = item.NumberOfTopics/*DataStructureInfo AssignSimpleProperty Bookstore.BooksWithTopics*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.BooksWithTopics.NumberOfTopics*/
        public int? NumberOfTopics { get; set; }
        /*DataStructureInfo ClassBody Bookstore.BooksWithTopics*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.BookTopic*/
    public class BookTopic : EntityBase<Bookstore.BookTopic>/*Next DataStructureInfo ClassInterace Bookstore.BookTopic*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_BookTopic ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_BookTopic
            {
                ID = item.ID,
                BookID = item.BookID,
                TopicID = item.TopicID/*DataStructureInfo AssignSimpleProperty Bookstore.BookTopic*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.BookTopic.BookID*/
        public Guid? BookID { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.BookTopic.TopicID*/
        public Guid? TopicID { get; set; }
        /*DataStructureInfo ClassBody Bookstore.BookTopic*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ChildrensBook*/
    public class ChildrensBook : EntityBase<Bookstore.ChildrensBook>/*Next DataStructureInfo ClassInterace Bookstore.ChildrensBook*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_ChildrensBook ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_ChildrensBook
            {
                ID = item.ID,
                AgeFrom = item.AgeFrom,
                AgeTo = item.AgeTo/*DataStructureInfo AssignSimpleProperty Bookstore.ChildrensBook*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.ChildrensBook.AgeFrom*/
        public int? AgeFrom { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.ChildrensBook.AgeTo*/
        public int? AgeTo { get; set; }
        /*DataStructureInfo ClassBody Bookstore.ChildrensBook*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Comment*/
    public class Comment : EntityBase<Bookstore.Comment>/*Next DataStructureInfo ClassInterace Bookstore.Comment*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Comment ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Comment
            {
                ID = item.ID,
                BookID = item.BookID,
                Text = item.Text/*DataStructureInfo AssignSimpleProperty Bookstore.Comment*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.Comment.BookID*/
        public Guid? BookID { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Comment.Text*/
        public string Text { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Comment*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.CommonMisspelling*/
    public class CommonMisspelling/*DataStructureInfo ClassInterace Bookstore.CommonMisspelling*/
    {
        /*DataStructureInfo ClassBody Bookstore.CommonMisspelling*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ComplexSearch*/
    public class ComplexSearch/*DataStructureInfo ClassInterace Bookstore.ComplexSearch*/
    {
        [DataMember]/*PropertyInfo Attribute Bookstore.ComplexSearch.ForeignBooksOnly*/
        public bool? ForeignBooksOnly { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.ComplexSearch.MaskTitles*/
        public bool? MaskTitles { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.ComplexSearch.MinimumPages*/
        public int? MinimumPages { get; set; }
        /*DataStructureInfo ClassBody Bookstore.ComplexSearch*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ContainsLockMark*/
    public class ContainsLockMark/*DataStructureInfo ClassInterace Bookstore.ContainsLockMark*/
    {
        /*DataStructureInfo ClassBody Bookstore.ContainsLockMark*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Employee*/
    public class Employee : EntityBase<Bookstore.Employee>/*Next DataStructureInfo ClassInterace Bookstore.Employee*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Employee ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Employee
            {
                ID = item.ID,
                UserName = item.UserName/*DataStructureInfo AssignSimpleProperty Bookstore.Employee*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.Employee.UserName*/
        public string UserName { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Employee*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ForeignBook*/
    public class ForeignBook : EntityBase<Bookstore.ForeignBook>/*Next DataStructureInfo ClassInterace Bookstore.ForeignBook*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_ForeignBook ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_ForeignBook
            {
                ID = item.ID,
                OriginalLanguage = item.OriginalLanguage,
                TranslatorID = item.TranslatorID/*DataStructureInfo AssignSimpleProperty Bookstore.ForeignBook*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.ForeignBook.OriginalLanguage*/
        public string OriginalLanguage { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.ForeignBook.TranslatorID*/
        public Guid? TranslatorID { get; set; }
        /*DataStructureInfo ClassBody Bookstore.ForeignBook*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Genre*/
    public class Genre : EntityBase<Bookstore.Genre>/*Next DataStructureInfo ClassInterace Bookstore.Genre*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Genre ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Genre
            {
                ID = item.ID,
                Description = item.Description,
                IsFiction = item.IsFiction,
                Label = item.Label,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Genre*/
            };
        }

        public static readonly Guid Biography = new Guid("dabe2d94-7191-579a-8e95-f5d395aee8f7");

        public static readonly Guid ScienceFiction = new Guid("3fc47b39-fca4-0786-9d05-039834344591");

        [DataMember]/*PropertyInfo Attribute Bookstore.Genre.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Genre.IsFiction*/
        public bool? IsFiction { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Genre.Label*/
        public string Label { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Genre.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Genre*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Insert5Books*/
    public class Insert5Books/*DataStructureInfo ClassInterace Bookstore.Insert5Books*/
    {
        /*DataStructureInfo ClassBody Bookstore.Insert5Books*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.InsertManyBooks*/
    public class InsertManyBooks/*DataStructureInfo ClassInterace Bookstore.InsertManyBooks*/
    {
        [DataMember]/*PropertyInfo Attribute Bookstore.InsertManyBooks.NumberOfBooks*/
        public int? NumberOfBooks { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.InsertManyBooks.TitlePrefix*/
        public string TitlePrefix { get; set; }
        /*DataStructureInfo ClassBody Bookstore.InsertManyBooks*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.LongBooks*/
    public class LongBooks/*DataStructureInfo ClassInterace Bookstore.LongBooks*/
    {
        /*DataStructureInfo ClassBody Bookstore.LongBooks*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.LongBooks3*/
    public class LongBooks3/*DataStructureInfo ClassInterace Bookstore.LongBooks3*/
    {
        [DataMember]/*PropertyInfo Attribute Bookstore.LongBooks3.ForeignBooksOnly*/
        public bool? ForeignBooksOnly { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.LongBooks3.MinimumPages*/
        public int? MinimumPages { get; set; }
        /*DataStructureInfo ClassBody Bookstore.LongBooks3*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Person*/
    public class Person : EntityBase<Bookstore.Person>/*Next DataStructureInfo ClassInterace Bookstore.Person*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Person ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Person
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Person*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.Person.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Person*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ShortBooks*/
    public class ShortBooks/*DataStructureInfo ClassInterace Bookstore.ShortBooks*/
    {
        /*DataStructureInfo ClassBody Bookstore.ShortBooks*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ShortBooks2*/
    public class ShortBooks2/*DataStructureInfo ClassInterace Bookstore.ShortBooks2*/
    {
        /*DataStructureInfo ClassBody Bookstore.ShortBooks2*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.SystemRequiredActive*/
    public class SystemRequiredActive/*DataStructureInfo ClassInterace Bookstore.SystemRequiredActive*/
    {
        /*DataStructureInfo ClassBody Bookstore.SystemRequiredActive*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.SystemRequiredBook*/
    public class SystemRequiredBook/*DataStructureInfo ClassInterace Bookstore.SystemRequiredBook*/
    {
        /*DataStructureInfo ClassBody Bookstore.SystemRequiredBook*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.SystemRequiredCode*/
    public class SystemRequiredCode/*DataStructureInfo ClassInterace Bookstore.SystemRequiredCode*/
    {
        /*DataStructureInfo ClassBody Bookstore.SystemRequiredCode*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Topic*/
    public class Topic : EntityBase<Bookstore.Topic>/*Next DataStructureInfo ClassInterace Bookstore.Topic*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Topic ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Topic
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Topic*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.Topic.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Topic*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.BookStoreGrid*/
    public class BookStoreGrid : EntityBase<Bookstore.BookStoreGrid>/*Next DataStructureInfo ClassInterace Bookstore.BookStoreGrid*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_BookStoreGrid ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_BookStoreGrid
            {
                ID = item.ID,
                AuthorName = item.AuthorName,
                NumberOfTopics = item.NumberOfTopics,
                Title = item.Title/*DataStructureInfo AssignSimpleProperty Bookstore.BookStoreGrid*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.BookStoreGrid.AuthorName*/
        public string AuthorName { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.BookStoreGrid.NumberOfTopics*/
        public int? NumberOfTopics { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.BookStoreGrid.Title*/
        public string Title { get; set; }
        /*DataStructureInfo ClassBody Bookstore.BookStoreGrid*/
    }

    /*ModuleInfo Body Bookstore*/

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}

namespace Common.Queryable
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

    /*DataStructureInfo QueryableClassAttributes Bookstore.Book*/
    public class Bookstore_Book : global::Bookstore.Book, IQueryableEntity<Bookstore.Book>, System.IEquatable<Bookstore_Book>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Book*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Book ToSimple()
        {
            var item = this;
            return new Bookstore.Book
            {
                ID = item.ID,
                Active = item.Active,
                BookCreated = item.BookCreated,
                Code = item.Code,
                Modified = item.Modified,
                NumberOfPages = item.NumberOfPages,
                Started = item.Started,
                Title = item.Title,
                AuthorID = item.AuthorID/*DataStructureInfo AssignSimpleProperty Bookstore.Book*/
            };
        }

        private Common.Queryable.Bookstore_BookInfo _extension_BookInfo;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_BookInfo*/
        public virtual Common.Queryable.Bookstore_BookInfo Extension_BookInfo
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_BookInfo*/
                return _extension_BookInfo;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_BookInfo*/
                _extension_BookInfo = value;
            }
        }

        private Common.Queryable.Bookstore_BooksWithTopics _extension_BooksWithTopics;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_BooksWithTopics*/
        public virtual Common.Queryable.Bookstore_BooksWithTopics Extension_BooksWithTopics
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_BooksWithTopics*/
                return _extension_BooksWithTopics;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_BooksWithTopics*/
                _extension_BooksWithTopics = value;
            }
        }

        private Common.Queryable.Bookstore_ChildrensBook _extension_ChildrensBook;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_ChildrensBook*/
        public virtual Common.Queryable.Bookstore_ChildrensBook Extension_ChildrensBook
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_ChildrensBook*/
                return _extension_ChildrensBook;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_ChildrensBook*/
                _extension_ChildrensBook = value;
            }
        }

        private Common.Queryable.Bookstore_ForeignBook _extension_ForeignBook;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_ForeignBook*/
        public virtual Common.Queryable.Bookstore_ForeignBook Extension_ForeignBook
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_ForeignBook*/
                return _extension_ForeignBook;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_ForeignBook*/
                _extension_ForeignBook = value;
            }
        }

        private Common.Queryable.Bookstore_Person _author;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Author*/
        public virtual Common.Queryable.Bookstore_Person Author
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Author*/
                return _author;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Author*/
                _author = value;
                AuthorID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Bookstore_BookStoreGrid _extension_BookStoreGrid;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_BookStoreGrid*/
        public virtual Common.Queryable.Bookstore_BookStoreGrid Extension_BookStoreGrid
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_BookStoreGrid*/
                return _extension_BookStoreGrid;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_BookStoreGrid*/
                _extension_BookStoreGrid = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Book*/

        public bool Equals(Bookstore_Book other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.BookInfo*/
    public class Bookstore_BookInfo : global::Bookstore.BookInfo, IQueryableEntity<Bookstore.BookInfo>, System.IEquatable<Bookstore_BookInfo>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.BookInfo*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.BookInfo ToSimple()
        {
            var item = this;
            return new Bookstore.BookInfo
            {
                ID = item.ID,
                NumberOfComments = item.NumberOfComments/*DataStructureInfo AssignSimpleProperty Bookstore.BookInfo*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.BookInfo.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BookInfo.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BookInfo.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.BookInfo*/

        public bool Equals(Bookstore_BookInfo other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.BooksWithTopics*/
    public class Bookstore_BooksWithTopics : global::Bookstore.BooksWithTopics, IQueryableEntity<Bookstore.BooksWithTopics>, System.IEquatable<Bookstore_BooksWithTopics>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.BooksWithTopics*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.BooksWithTopics ToSimple()
        {
            var item = this;
            return new Bookstore.BooksWithTopics
            {
                ID = item.ID,
                NumberOfTopics = item.NumberOfTopics/*DataStructureInfo AssignSimpleProperty Bookstore.BooksWithTopics*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.BooksWithTopics.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BooksWithTopics.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BooksWithTopics.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.BooksWithTopics*/

        public bool Equals(Bookstore_BooksWithTopics other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.BookTopic*/
    public class Bookstore_BookTopic : global::Bookstore.BookTopic, IQueryableEntity<Bookstore.BookTopic>, System.IEquatable<Bookstore_BookTopic>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.BookTopic*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.BookTopic ToSimple()
        {
            var item = this;
            return new Bookstore.BookTopic
            {
                ID = item.ID,
                BookID = item.BookID,
                TopicID = item.TopicID/*DataStructureInfo AssignSimpleProperty Bookstore.BookTopic*/
            };
        }

        private Common.Queryable.Bookstore_Book _book;

        /*DataStructureQueryable PropertyAttribute Bookstore.BookTopic.Book*/
        public virtual Common.Queryable.Bookstore_Book Book
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BookTopic.Book*/
                return _book;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BookTopic.Book*/
                _book = value;
                BookID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Bookstore_Topic _topic;

        /*DataStructureQueryable PropertyAttribute Bookstore.BookTopic.Topic*/
        public virtual Common.Queryable.Bookstore_Topic Topic
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BookTopic.Topic*/
                return _topic;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BookTopic.Topic*/
                _topic = value;
                TopicID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.BookTopic*/

        public bool Equals(Bookstore_BookTopic other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.ChildrensBook*/
    public class Bookstore_ChildrensBook : global::Bookstore.ChildrensBook, IQueryableEntity<Bookstore.ChildrensBook>, System.IEquatable<Bookstore_ChildrensBook>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.ChildrensBook*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.ChildrensBook ToSimple()
        {
            var item = this;
            return new Bookstore.ChildrensBook
            {
                ID = item.ID,
                AgeFrom = item.AgeFrom,
                AgeTo = item.AgeTo/*DataStructureInfo AssignSimpleProperty Bookstore.ChildrensBook*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.ChildrensBook.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.ChildrensBook.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.ChildrensBook.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.ChildrensBook*/

        public bool Equals(Bookstore_ChildrensBook other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.Comment*/
    public class Bookstore_Comment : global::Bookstore.Comment, IQueryableEntity<Bookstore.Comment>, System.IEquatable<Bookstore_Comment>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Comment*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Comment ToSimple()
        {
            var item = this;
            return new Bookstore.Comment
            {
                ID = item.ID,
                BookID = item.BookID,
                Text = item.Text/*DataStructureInfo AssignSimpleProperty Bookstore.Comment*/
            };
        }

        private Common.Queryable.Bookstore_Book _book;

        /*DataStructureQueryable PropertyAttribute Bookstore.Comment.Book*/
        public virtual Common.Queryable.Bookstore_Book Book
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Comment.Book*/
                return _book;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Comment.Book*/
                _book = value;
                BookID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Comment*/

        public bool Equals(Bookstore_Comment other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.Employee*/
    public class Bookstore_Employee : global::Bookstore.Employee, IQueryableEntity<Bookstore.Employee>, System.IEquatable<Bookstore_Employee>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Employee*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Employee ToSimple()
        {
            var item = this;
            return new Bookstore.Employee
            {
                ID = item.ID,
                UserName = item.UserName/*DataStructureInfo AssignSimpleProperty Bookstore.Employee*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Employee*/

        public bool Equals(Bookstore_Employee other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.ForeignBook*/
    public class Bookstore_ForeignBook : global::Bookstore.ForeignBook, IQueryableEntity<Bookstore.ForeignBook>, System.IEquatable<Bookstore_ForeignBook>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.ForeignBook*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.ForeignBook ToSimple()
        {
            var item = this;
            return new Bookstore.ForeignBook
            {
                ID = item.ID,
                OriginalLanguage = item.OriginalLanguage,
                TranslatorID = item.TranslatorID/*DataStructureInfo AssignSimpleProperty Bookstore.ForeignBook*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.ForeignBook.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.ForeignBook.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.ForeignBook.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        private Common.Queryable.Bookstore_Person _translator;

        /*DataStructureQueryable PropertyAttribute Bookstore.ForeignBook.Translator*/
        public virtual Common.Queryable.Bookstore_Person Translator
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.ForeignBook.Translator*/
                return _translator;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.ForeignBook.Translator*/
                _translator = value;
                TranslatorID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.ForeignBook*/

        public bool Equals(Bookstore_ForeignBook other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.Genre*/
    public class Bookstore_Genre : global::Bookstore.Genre, IQueryableEntity<Bookstore.Genre>, System.IEquatable<Bookstore_Genre>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Genre*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Genre ToSimple()
        {
            var item = this;
            return new Bookstore.Genre
            {
                ID = item.ID,
                Description = item.Description,
                IsFiction = item.IsFiction,
                Label = item.Label,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Genre*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Genre*/

        public bool Equals(Bookstore_Genre other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.Person*/
    public class Bookstore_Person : global::Bookstore.Person, IQueryableEntity<Bookstore.Person>, System.IEquatable<Bookstore_Person>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Person*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Person ToSimple()
        {
            var item = this;
            return new Bookstore.Person
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Person*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Person*/

        public bool Equals(Bookstore_Person other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.Topic*/
    public class Bookstore_Topic : global::Bookstore.Topic, IQueryableEntity<Bookstore.Topic>, System.IEquatable<Bookstore_Topic>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Topic*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Topic ToSimple()
        {
            var item = this;
            return new Bookstore.Topic
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Topic*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Topic*/

        public bool Equals(Bookstore_Topic other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.BookStoreGrid*/
    public class Bookstore_BookStoreGrid : global::Bookstore.BookStoreGrid, IQueryableEntity<Bookstore.BookStoreGrid>, System.IEquatable<Bookstore_BookStoreGrid>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.BookStoreGrid*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.BookStoreGrid ToSimple()
        {
            var item = this;
            return new Bookstore.BookStoreGrid
            {
                ID = item.ID,
                AuthorName = item.AuthorName,
                NumberOfTopics = item.NumberOfTopics,
                Title = item.Title/*DataStructureInfo AssignSimpleProperty Bookstore.BookStoreGrid*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.BookStoreGrid.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BookStoreGrid.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BookStoreGrid.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.BookStoreGrid*/

        public bool Equals(Bookstore_BookStoreGrid other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*ModuleInfo CommonQueryableMemebers Bookstore*/

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}
