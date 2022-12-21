#include<iostream>
#include<cstdlib>
#include<conio.h>
#include<time.h>
using namespace std;

int roll_dice()
{
    int dice,moves=0;
    srand(time(NULL));
    extra:
    dice = 1+(rand() %60);
    if(dice>0 && dice<=20) dice=1;
    if(dice>20 && dice<=40) dice=2;
    if(dice>40 && dice<=50) dice=3;
    if(dice>50 && dice<=55) dice=4;
    if(dice>55 && dice<=60) dice=8;

    moves+=dice;
    cout<<"Dice : "<<dice<<endl;
    cout<<"Total Move : "<<moves<<endl;
    if(dice==8 || dice==4) 
    {     
        cout<<"Bonus, press again - "<<endl;
        getch();  
        goto extra;
    }
    return moves;
}
int main()
{
    int moves,p=1;
    system("cls");
    cout<<"\n\nDice Mechanics For my board game version 1.0 - "<<endl;
    nextPlayer:
        moves=0;
        cout<<"Press any key to roll the Dice - "<<endl;
        getch();
        moves = roll_dice();
        cout<<"Total Moves in Game : "<<moves<<endl; p++;
        cout<<"\nNext Player ("<<p<<")"<<endl;   
    goto nextPlayer;
    return 0;
}