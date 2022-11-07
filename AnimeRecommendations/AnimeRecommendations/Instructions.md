Project:

Feature Epic > BE tickets – user > sub tickets (tasks) – create user, add , user, delete

Validations:
Mandatory:
IsManga  Do we have a value? – nullable bool
IsHardcopy If value is true or false ; if false check uri (optional and mandatory in some cases)
Title
Genre(optional)
Demographic(optional)
Score(optional)


Create user
Step 1  - validate
Step 2  - add new entry (use InMemoryCache)
Step 3 -  return result of doing the above
Step 4 Create Integration tests class

//test endpoints 
