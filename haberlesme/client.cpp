#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <errno.h>
#include <string.h>
#include <netdb.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>

#define PORT 3490
#define MAXSIZE 1024

void connect(char * buffer, char * ipAddr);

int main(int argc, char *argv[])
{
	char data[MAXSIZE];
	char ip[100];

	sprintf(data,"merhaba");
	sprintf(ip,"localhost");
	connect(data,ip);
    
}//End of main


void connect(char * buffer1, char * ipAddr){

	struct sockaddr_in server_info;
    struct hostent *he;
    int socket_fd,num;
    char buffer[1024];
    sprintf(buffer,"hy");

    char buff[1024];

    if ((he = gethostbyname(ipAddr))==NULL) {
        fprintf(stderr, "Cannot get host name\n");
        exit(1);
    }
    if ((socket_fd = socket(AF_INET, SOCK_STREAM, 0))== -1) {
        fprintf(stderr, "Socket Failure!!\n");
        exit(1);
    }

    memset(&server_info, 0, sizeof(server_info));
    server_info.sin_family = AF_INET;
    server_info.sin_port = htons(PORT);
    server_info.sin_addr =	 *((struct in_addr *)he->h_addr);
    if (connect(socket_fd, (struct sockaddr *)&server_info, sizeof(struct sockaddr))<0) {
        //fprintf(stderr, "Connection Failure\n");
        perror("connect");
        exit(1);
    }

	
		if ((send(socket_fd,buffer, strlen(buffer),0))== -1) {
                fprintf(stderr, "Failure Sending Message\n");
                close(socket_fd);
                exit(1);
        }
        else {
                printf("Client:Message being sent: %s\n",buffer);
                num = recv(socket_fd, buffer, sizeof(buffer),0);
                if ( num <= 0 )
                {
                        printf("Either Connection Closed or Error\n");
                        return ;
                }

                buff[num] = '\0';
                printf("Client:Message Received From Server -  %s\n",buffer);
           }
           
		//sprintf(buffer,"merhaba langggggdsasmerhaba langggggdsasmerhaba langggggdsasmerhaba langggggdsasmerhaba langggggdsas");
		for(int i = 0 ; i < 1000;i++)
			buffer[i]=i%100+1;
		buffer[1000]='a';
		buffer[1001]='\n';	
        if ((send(socket_fd,buffer, strlen(buffer),0))== -1) {
                fprintf(stderr, "Failure Sending Message\n");
                close(socket_fd);
                exit(1);
        }
        else {
                printf("Client:Message being sent: %s\n",buffer);
                num = recv(socket_fd, buffer, sizeof(buffer),0);
                if ( num <= 0 )
                {
                        printf("Either Connection Closed or Error\n");
                        return ;
                }

                buff[num] = '\0';
                printf("Client:Message Received From Server -  %s\n",buffer);
           }
 
    close(socket_fd);

}