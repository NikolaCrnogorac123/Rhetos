<Query Kind="Program">
  <Connection>
    <ID>8c865afc-1d22-47b0-8151-62768c85d031</ID>
    <Persist>true</Persist>
    <Server>(localdb)\local</Server>
    <Database>BookStore</Database>
    <ShowServer>true</ShowServer>
  </Connection>
  <Reference Relative="..\bin\Autofac.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Autofac.dll</Reference>
  <Reference Relative="..\bin\EntityFramework.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\EntityFramework.dll</Reference>
  <Reference Relative="..\bin\EntityFramework.SqlServer.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\EntityFramework.SqlServer.dll</Reference>
  <Reference Relative="..\bin\Bookstore.Service.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Bookstore.Service.dll</Reference>
  <Reference>..\bin\Generated\ServerDom.Orm.dll</Reference>
  <Reference>..\bin\Generated\ServerDom.Repositories.dll</Reference>
  <Reference Relative="..\bin\NLog.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\NLog.dll</Reference>
  <Reference Relative="..\bin\Oracle.ManagedDataAccess.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Oracle.ManagedDataAccess.dll</Reference>
  <Reference>..\bin\Rhetos.AspNetFormsAuth.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Dom.DefaultConcepts.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Dom.DefaultConcepts.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Dom.DefaultConcepts.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Dom.DefaultConcepts.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Dsl.DefaultConcepts.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Dsl.DefaultConcepts.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Processing.DefaultCommands.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Processing.DefaultCommands.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Configuration.Autofac.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Configuration.Autofac.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Dom.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Dom.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Dsl.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Dsl.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Logging.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Logging.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Persistence.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Persistence.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Processing.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Processing.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Security.Interfaces.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Security.Interfaces.dll</Reference>
  <Reference Relative="..\bin\Rhetos.TestCommon.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.TestCommon.dll</Reference>
  <Reference Relative="..\bin\Rhetos.Utilities.dll">&lt;MyDocuments&gt;\TargetFolder\Bookstore.Service\Bookstore.Service\bin\Rhetos.Utilities.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.DirectoryServices.AccountManagement.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.DirectoryServices.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>Oracle.ManagedDataAccess.Client</Namespace>
  <Namespace>Rhetos.Configuration.Autofac</Namespace>
  <Namespace>Rhetos.Dom</Namespace>
  <Namespace>Rhetos.Dom.DefaultConcepts</Namespace>
  <Namespace>Rhetos.Dsl</Namespace>
  <Namespace>Rhetos.Dsl.DefaultConcepts</Namespace>
  <Namespace>Rhetos.Logging</Namespace>
  <Namespace>Rhetos.Persistence</Namespace>
  <Namespace>Rhetos.Security</Namespace>
  <Namespace>Rhetos.Utilities</Namespace>
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
  <Namespace>System.Data.Entity</Namespace>
  <Namespace>System.DirectoryServices</Namespace>
  <Namespace>System.DirectoryServices.AccountManagement</Namespace>
  <Namespace>System.IO</Namespace>
  <Namespace>System.Linq</Namespace>
  <Namespace>System.Reflection</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Text</Namespace>
  <Namespace>System.Xml</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
  <Namespace>Autofac</Namespace>
  <Namespace>Rhetos.TestCommon</Namespace>
  <Namespace>Rhetos</Namespace>
</Query>

void Main()
{
	string applicationFolder = Path.GetDirectoryName(Util.CurrentQueryPath);
	ConsoleLogger.MinLevel = EventType.Info; // Use EventType.Trace for more detailed log.
	
	using (var scope = ProcessContainer.CreateScope(applicationFolder))
    {
        var context = scope.Resolve<Common.ExecutionContext>();
		var repository = context.Repository;
		var Books = repository.Bookstore.Book.Load().Select(books => new { books.Title, books.AuthorID }).Dump();

		/* USING COMPOSABLEFILTER TO GET OUTPUT
		var filterParameters = new Bookstore.AverageBooks{
			MinimumPages=0,
			MaximumPages=500
		};
		
		var query = repository.Bookstore.Book.Query(filterParameters);
		query.ToSimple().ToList().Dump();
		*/

		/*		Get Book title and Author with Load()
		
				var Books = repository.Bookstore.Book.Load();
				Books.Select(books => new{books.Title,books.AuthorID}).Dump();
		*/
		
		//							Query with book title and author name
		
		//var newBook = repository.Bookstore.Book.Query().Select(books => new{books.Title,books.Author}).Dump();
		/*							Objasnjavanje LinqPad-a od kolega
		var tempAuthor = new Guid("E2BE74D4-EC64-4FB3-BCA1-1DFD15F65A0C")
		
		var person = repository.Bookstore.Author
			.Query(x=> x.Name == tempAuthor)
			.Select(x=> x.ID)
			.ToList();
			
		*/
		//							With ToString method
		//query.Select(book => new{book.Title,book.Author}).ToString().Dump();
		
		// 							Add 5 books with hardcoded names
		//repository.Bookstore.Insert5Books.Execute(null);
		//scope.CommitAndClose();
		//
		//var book = repository.Bookstore.Book
		//	.Query(x => x.Title == "Book0")
		//	.Select(x => x.ID)
		//	.ToList()
		//	.Dump();
		
		// 							Add x amount of books with names
		/*var actionParameter = new Bookstore.InsertManyBooks
		{
    		NumberOfBooks = 7,
    		TitlePrefix = "A Song of Ice and Fire"
		};
		repository.Bookstore.InsertManyBooks.Execute(actionParameter);
		scope.CommitAndClose();
		*/


		//Rješenje pitanja iz 1. dana
		//Razlog dobivanja drugačijih rezultata u sve tri linije je poredak komandi nakon query.
		//Nakon ToList() ništa drugo ne dolazi u obzir jer se query morao pozvati kako bi napunio listu
		//Te uzima sve parametre do tada odabrane kako bi kreirao taj upit koji puni listu
		//3. Zadnja komentirana linija unutar LinqPada baca compile error zato što možemo koristit samo jednostavne izraze nakon =>
    }
}