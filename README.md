# customer-api

### Description
The project implement a simple CRUD based api to access & modify the customer in-memory database. 

Currently the API allows to CREATE, READ, UPDATE and DELETE customer information that has been saved in in memory database.

### Getting Started

1. Installation Process:

	Follow the below steps:
	
		Download the latest code from master branch.

2. Software Dependencies:

	Following are the software / tools used for development & test
	
		- Visual Studio 2022
		- .Net SDK 7
		- Swagger

3. Latest version:


### Build & Test

1.1 Build & Run:

	- Download the latest code from the master branch.
	- Build & Run the `CustomerAPISol.sln` solution from your IDE (Visual Studio 2022)
	
	After runing the solution file a new browser window will open with Swagger API platform.

	##### POST Reqeust: 
	
		Since the project use in-memory databse, use the following steps to create user in in-memory database using `POST` request
	
			- From the Swagger API platform in broswer, open the dropdown menu of `POST` reqeust and then press the "Try Out" button.
			- In the request body for the POST, enter the following JSON code to create dummy user and press the `Execute`.

			```json
			"customer": {
			"id": 1,
			"name": "Judith",
			"address": "Stockholm"
			}
			```
			You can add more user in the json array and check the response at the bottom of the `POST` dropdown menu.
	
	##### READ Request:
		
		To read the value from the database, simply press the 'Try Out' button inside the GET drowpdown and press execute.
		
		You will youe newely created user in the response body.


	##### PUT Request:

		Similary to update the user, 
		
			- Open the dropdown menu of `PUT` and and then press the "Try Out" button.
			- In the request body for the PUT, enter the following JSON code to create dummy user & press the `Execute` button.

			```json
			"customer": {
			"id": 1,
			"name": "Peter",
			"address": "Luxumberg"
			}
			```

			You can check the response body at the bottom of the `PUT` dropdown menu.
	
	##### DELETE Request:

	Finally, To Delete the user, 
		- open the dropdown menu of `DELETE` and and then press the "Try Out" button.
		- In the request body for the DELETE, enter the id of the user that you wanted to delete & press the `Execute` button.
		
		For Example:
		
			```json
			{
			"id": 1
			}
			```

		Check the response body for the success message.

### Contact
Thank you for time to checkout the code.

For any query, please contact:

Deepika Sahu
sahudeepika898@gmail.com
	 
