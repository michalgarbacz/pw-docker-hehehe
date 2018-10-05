prerequisites:
	-docker installed
	-docker compose installed
	-docker machine running
	
setup/run :
	run powershell in project path <.../docker.web/docker.web>
	execute command: docker-compose -f docker-compose.qa.yaml up
	open web app: http://192.168.99.100:6153
	enjoy!