//
//  main.cpp
//  server
//
//  Created by ser on 12/10/13.
//  Copyright (c) 2013 ser. All rights reserved.
//
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

#include <stdio.h>
#include <stdlib.h>
#include <iostream>
//#include <tiffio.h>
#include <fstream>
#include <string.h>
#include <dirent.h>
#include <unistd.h>
#include <sys/stat.h>

#include <vector>

using namespace std;

#define PORT 3490
#define BACKLOG 10


void haberles();
void mtlHazirla();
int *  mtlKoseOku(char *   filename);
vector <string> browse(char * root);
void hazirla();

vector <string> dosyaIsimleri;
vector<int > koseler;
vector<int > utm;
int minx = 1000000, maxx = 0, miny = 5041000, maxy = 0;


int main(int argc, const char * argv[])
{
    mtlHazirla();
    hazirla();
 //   haberles();
    return 0;
}


void hazirla(){

    
    
	for (int i = 0; i <koseler.size()/2; i++)
        if(koseler[i*2]!=0 && utm[i/4]==35 ){
            if (koseler[i*2] > maxx)
                maxx = koseler[i * 2];
            if (koseler[i * 2] < minx){
                minx = koseler[i * 2];
            }
            if (koseler[i * 2+1] > maxy)
                maxy = koseler[i * 2+1];
            if (koseler[i* 2+1] < miny)
                miny = koseler[i * 2+1];
        }
    
	cout << " minx = "<< minx<<"\t maxx = "<< maxx<<"\n miny = "<< miny<<"\t maxy = "<< maxy<<endl;
	unsigned short *outputImage = new unsigned short[((maxy - miny) / 30 + 1)* ((maxx - minx) / 30 + 1)];
    cout << "tamam"<<endl;
}

void haberles(){
    
    struct sockaddr_in server;
    struct sockaddr_in dest;
    int status,socket_fd, client_fd,num;
    socklen_t size;
    
    char buffer[10241];
    char *buff;
    
    int yes =1;
    
    
    
    if ((socket_fd = socket(AF_INET, SOCK_STREAM, 0))== -1) {
        fprintf(stderr, "Socket failure!!\n");
        exit(1);
    }
    
    if (setsockopt(socket_fd, SOL_SOCKET, SO_REUSEADDR, &yes, sizeof(int)) == -1) {
        perror("setsockopt");
        exit(1);
    }
    memset(&server, 0, sizeof(server));
    memset(&dest,0,sizeof(dest));
    server.sin_family = AF_INET;
    server.sin_port = htons(PORT);
    server.sin_addr.s_addr = INADDR_ANY;
    //if ((bind(socket_fd, (struct sockaddr *)&server, sizeof(struct sockaddr )))== -1)    {
    if ((int)(bind(socket_fd, (struct sockaddr *)&server, sizeof(struct sockaddr )))== -1)    { //sizeof(struct sockaddr)
        fprintf(stderr, "Binding Failure\n");
        exit(1);
    }
    
    if ((listen(socket_fd, BACKLOG))== -1){
        fprintf(stderr, "Listening Failure\n");
        exit(1);
    }
    
    
    while(1) {
		int messageCounter =0;
		
        size = sizeof(struct sockaddr_in);
        
        if ((client_fd = accept(socket_fd, (struct sockaddr *)&dest, &size))==-1 ) {
            perror("accept");
            exit(1);
        }
        printf("Server got connection from client %s\n", inet_ntoa(dest.sin_addr));
        
        while(1) {
			if(messageCounter == 0){
                if ((num = recv(client_fd, buffer, 1024,0))== -1) {
                    perror("recv");
                    exit(1);
                }
                else if (num == 0) {
                    printf("Connection closed\n");
                    
                    break;
                }
                
                buffer[num-1] = '1';
                buffer[num] = '1';
                buffer[num+1] = 'a';
                buffer[num+2] = '\0';
                
                printf("Server:Msg Received %s\n", buffer);
                if ((send(client_fd,buffer, strlen(buffer)+2,0))== -1)
                {
                    fprintf(stderr, "Failure Sending Message\n");
                    close(client_fd);
                    break;
                }
                
                printf("Server:Msg being sent: %s\nNumber of bytes sent: %d\n",buffer, (int)strlen(buffer));
                
            }
            
        }
        
        close(client_fd);
    } 
    
    close(socket_fd);
    return ;
    
}


void mtlHazirla(){
    char path[100] ="//Users//ser//Desktop//constanta lst8//";//"/mnt/data/hesapciYedek/landsat8tr/";
    dosyaIsimleri = browse(path);
	
	char dosyaIsmi[100];
	   
	for(int i = 0 ; i < dosyaIsimleri.size();i++){
        cout << dosyaIsimleri[i]<<endl;
		strcpy(dosyaIsmi,path);
		strcat(dosyaIsmi,(char*)dosyaIsimleri[i].c_str());
		strcat(dosyaIsmi,"/");
		strcat(dosyaIsmi,(char*)dosyaIsimleri[i].c_str());
		
		int * data =  mtlKoseOku(dosyaIsmi);
		
		if (data ==NULL)
			printf("data bozuk\n");
		
		for(int j = 0 ; j < 8 ; j++){
			if(data[0]!=-1){
                cout << data[j]<<endl;
				koseler.push_back( data[j] );
			}
			else{
			 	koseler.push_back(0);
			}
		}
        cout << endl;
		if(data[0]!=-1)
			utm.push_back(data[8]);
		else
			utm.push_back(0);
	}
    
}


vector <string> browse( char * root){
    
    DIR *dirp;
    struct dirent *dp;
	vector <string> dosyaIsimleri ;
    
    if ((dirp = opendir(root)) == NULL){
        
        perror("couldn't open '.'");
        return dosyaIsimleri;
    }
    
    do {
        
        if ((dp = readdir(dirp)) != NULL ) {
			
			if(strlen(dp->d_name) ==21){
                
				dosyaIsimleri.push_back(dp->d_name);
			}
            
            
        }
    } while (dp != NULL);
    
    
    closedir(dirp);
    return dosyaIsimleri;
}

int *  mtlKoseOku(char *   filename){
    
	int *koseler= new int[9];
	koseler[0]=-1;
	int kose = 0;
    int counter = 0 ;
    char *mtl = new char[200];
    mtl=filename;
    strcat(mtl,"_MTL.txt");
    ifstream iFile(mtl);
    if(!iFile){
        
        return koseler;
    }
    
    string line;
    
    /* While there is still a line. */
    while(getline(iFile, line)) {
        /* Printing goes here. */
        if (counter >= 30 && counter <= 37)
        {
			
            char * pch = strtok ((char *)line.c_str()," ");
            char * value;
            int counter1 =0;
            
            while (pch != NULL){
				
                if(counter1 == 2){
					
					string temp = pch;
                    
                    value=(char *)temp.substr(0,8).c_str();
                    
                    
					break;
                }
                counter1++;
                pch = strtok (NULL, " ");
            }
            
			
            koseler[kose++]=atoi(value);
            
        }
        else if(counter ==197){
            char * pch = strtok ((char *)line.c_str()," ");
            char * value;
            int counter1 =0;
			while (pch != NULL){
				if(counter1 == 2){
					string temp = pch;
					value=(char *)temp.substr(0,2).c_str();
					break;
				}
				counter1++;
				pch = strtok (NULL, " ");
			}
            
			koseler[kose++]=atoi(value);
		}
        counter++;
		
    }
    
    iFile.close();
	
	return koseler;
}






