# An e-commerce (shopping cart) application that integrates with Megaventory

## Documents
This Backend Web API is written in C# - ASP.NET Core. The application integrates some endpoints of Megaventory API.

Besides Programs.cs and configuration files, three folders that make up the API are ActionModels, Models and Controllers.
- ActionModels: Contains models of action parameters such as mvRecordAction and mvProduct, and an APIKEY parameter.
- Models: Contains models of data included in action objects. For example, mvProduct action object model may include ProductSKU and ProductDescription values.
- Controllers: Contains controllers that make use of the models above to POST update requests.

Basically, all endpoints bind data to models defined in Models folder. Then, those models are assigned to an instance of an action model. Action model properties themselves are also assigned. Finally, the instance is sent to update endpoints by POST method. There are three controllers in Controllers folder:
- EntitiesController (step 2): Insert or update entities (products, clients, suppliers, inventory locations).
- RelationshipController (step 3 & 4): Create or update product-client and product-supplier relationships.
- ProductAvailabilityController (step 5): Update the availability of products in a warehouse.

## Relation to a project in my CV
I wrote an ASP.NET full-stack project called "[The Quotes](https://github.com/MinhNhatTRUONG-2001/The_Quotes_ASPdotNET)" last year. I developed a Web API that connects to a local database in the project, so I somehow have already had some experiences while doing this coding assignment.