using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 class StoryBlock
{
    public string story;
    public string option1Text;
    public string option2Text;
    public StoryBlock option1Block;
    public StoryBlock option2Block;
    public StoryBlock(string story,string option1Text="",string option2Text="",StoryBlock option1Block=null,StoryBlock option2Block=null)
    {
        this.story=story;
        this.option1Text=option1Text;
        this.option2Text=option2Text;
        this.option1Block=option1Block;
        this.option2Block=option2Block;
    }
}
public class StoryMenager : MonoBehaviour
{
    [SerializeField] Text mainText;
    [SerializeField] Button option1;
    [SerializeField] Button option2;
    

    StoryBlock currentBlock;

static StoryBlock block7=new StoryBlock("To spierdalaj(GAME OVER)");//2.2
static StoryBlock block6=new StoryBlock("Zabiłeś ich zanim zdążyli stęknąć - brawo!( +10 expa)");//2.1
static StoryBlock block5=new StoryBlock("Przestań się tutaj użalać, wrogów trzeba wnet nawalać","Rozkaz wodzu, idę prędko, bedom martwi zanim stękną",
    "Daj mi spokój kurwa mać, nie chcę w grę grać, idę spać",block6,block7);//2
static StoryBlock block4=new StoryBlock("Stchórzyłeś, ale z Ciebie cipetta GAME OVER!");//1.2
static StoryBlock block3=new StoryBlock("ROZJEBAŁEŚ ŚWINIĘ I PAROBKA GRATULACJE (+5expa)");//1.1
static StoryBlock block2=new StoryBlock("Szkoda tylko, że o odwecie, świna przyjdzie wielka przecie","Ja się świni tej nie boję, bo mam dupę na naboje",
    "Teraz to już po mnie bracie, zrobi ze mnie swoje gacie..",block3,block4);//1
static StoryBlock block1=new StoryBlock("W małej wiosce Hohenroda, zacznię się Twoja przygoda, szykuj zatem się do starcia, wrogowie idą do natarcia! Patrz! Wrogowie idą grupą podły Chojrak z jakąś dupą!",
    "Cipa z niego niesłychana, uwinę się z tym do rana","Nie dam rady z tą baryłą, skończę pewnie pod mogiłą...",block2,block5);

    
    void Start()
    {
        DisplayBlock(block1);
        
    }
    void DisplayBlock(StoryBlock block)
    {
        
        mainText.text=block.story;
        option1.GetComponentInChildren<Text>().text=block.option1Text;
        option2.GetComponentInChildren<Text>().text=block.option2Text;

        currentBlock=block;
    }
    public void Button1Clicked()
    {
        DisplayBlock(currentBlock.option1Block);
    }
    public void Button2Clicked()
    {
        DisplayBlock(currentBlock.option2Block);
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
            
        }
    }
}
