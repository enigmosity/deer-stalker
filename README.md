# deer-stalker
A site for NZ hunters to enter their shots so that they may have a data-based discussion about their impact to pest control in NZ


Current point:
- have followed a very basic .net core web application tutorial. 

Next steps:
- create a dynamodb table to store the data in. it needs to be encrypted at rest.
- use terraform to create the dynamodb table
- get some data entry UI going on, rather than just through the url
- get the application running on a docker container
- get the application running on a docker container and managed using terraform for AWS
- once all that is looking good, consider actually implementing a nice UI

Notes:
- currently to access the enter hunt page, you need to go to hunt/enterhunt

