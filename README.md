# fullstack

1. https://docs.microsoft.com/en-us/sql/linux/quickstart-install-connect-docker?view=sql-server-ver15&pivots=cs1-cmd

Step: 
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=sqlserver1" -p 1433:1433 --name sql1 -h sql1 -d mcr.microsoft.com/mssql/server:2019-latest

docker exec -it sql1 "bash"

/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "Sqlserver1"


Sql server
ID: SA
Password: Sqlserver1

* Download and install Azure Data Studio: https://docs.microsoft.com/en-us/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15#download-azure-data-studio


https://www.quackit.com/sql_server/mac/how_to_copy_a_file_from_the_host_to_a_docker_container.cfm

https://database.guide/how-to-install-azure-data-studio-on-a-mac/

https://docs.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver15&tabs=ssms

