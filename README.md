# Database Ordering Application
This is a database system created for [Topline Paint](http://www.toplinepaint.com.au/). It is a [Visual C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)#Implementations) program created expressly for the use at Topline.

Moving parts discussion:
1. The first notable working part is the [DBControl](https://github.com/ToplinePaint/database_system_topline/blob/master/database_app_test/DBControl.cs) script, which uses the [OleDB](https://en.wikipedia.org/wiki/OLE_DB) Driver for [SQL](https://en.wikipedia.org/wiki/SQL) to extract information from an Access database. This script is (like the rest of the project) written in Visual C# and is a [class](https://en.wikipedia.org/wiki/Class_(computer_programming)) which can be imported by other parts of the project to act as [middleware](https://en.wikipedia.org/wiki/Middleware) for the application and the database.

2. The [Home](https://github.com/ToplinePaint/database_system_topline/blob/master/database_app_test/Home.cs) script is the main page for the interface and manages which subforms are open. It does not make use of the DBControl script as of right now, but it could do in the future.

3. The [Orders](https://github.com/ToplinePaint/database_system_topline/blob/master/database_app_test/Orders.cs) subform is a messy program which needs to be cleaned up considerably. It is the main ordering page currently. It can only extract information so far, it cannot do anything that advanced in terms of creating orders, but is the major project so far.

