# BackgroundVerify

Flow :
after submitting details on frontend page(index), it makes an ajax call to the backend API with JSON payload containing employee ID, company name, and verification code which in 
return tell you whether employee exists or not , if yes the returns Verified response else not verified.

for seeding employee data ,used in-memory data structure.

By default after running the solution frontend page index.html will be hit with https profile, if need to open swagger endpoint,you can access it via /swagger
e.g.   Default : https://localhost:7012/index.html
       Swagger : https://localhost:7012/swagger
