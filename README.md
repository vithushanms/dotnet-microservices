# dotnet-microservices

This repository contains a template smaple containerized Microservice project

## case study scenario

Since this is a template project we are going to make the usecase very simple. 
This case study is based on a flight booking scenario. the requirement is to check the availablility of the flights and plcae the booking.

So for any microservice implementation as a best practice, we need to start the seperation of service from domain level. so here we will be seprating the scenario into to two domains, flight availability and the flight booking. so the domains here are going to be considered as the services of this application. each will be developed seperately with totally isollated databases.
each of them communicate using http client, grpc and a message broker.

for further context please refer to the high level [solution architecture](https://github.com/vithushanms/dotnet-microservices/blob/main/solution_architecture.drawio.png) diagram of this template

## technologies used
.NET 6 </br>
Rabbit MQ </br>
Docker </br>
</br>