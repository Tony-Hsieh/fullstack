# Day0: Install Environment For Mac

Install
1. Sql Server
2. Azure Data Studio
3. Dataset Download

## Sql Server
Instruction: https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver15&pivots=cs1-cmd

Setup
* docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Sqlserver1" -p 1433:1433 --name sql1 -h sql1 -d mcr.microsoft.com/mssql/server:2019-latest

Run
* docker container start sql1

* docker exec -it sql1 "bash"

* /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Sqlserver1"

## Azure Data Studio

Download and install Azure Data Studio: https://database.guide/how-to-install-azure-data-studio-on-a-mac/

Server: localhost  
User Name: sa  
Password: Sqlserver1

## Dataset Download

* Download AdventureWorks2019.bak from: https://docs.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver15&tabs=ssms
* Restore backup file: https://www.quackit.com/sql_server/mac/how_to_copy_a_file_from_the_host_to_a_docker_container.cfm

