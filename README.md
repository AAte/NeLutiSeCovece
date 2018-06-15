# NeLutiSeCovece

## Проект по предметот Визуелно Програмирање
Членови на тимот: 
- Атанас Аспровски 151162
- Димитар Ѓошев 153030
- Стефан Пешевски 153013

**Напомена: Проектот е изработен на поголем екран и не е добро скалиран за помала резолуција како 1280 x 720. Работи добро на резолуции како 1600 x 900 и резолуции поголеми од наведената.** 

### Објаснување на проблемот 
За овој проект ние решивме да направиме имплементација на веќе постоечката и познатата игра "Не лути се човече!" во Windows Forms. Нашата имплементација ги има сите функционалности како и оргиналната игра и исто така се придржува според стандардните правила на игра. Начинот на играње е прилично едноставен. За да се започне играта потребни се барем двајца играчи а највеќе може да има четири играчи. Играчот кој сите фигури ќе ги смести во базата победува. На почетокот на играта секој играч ја фрла коцката, доколку некој добие број шест поставува една фигура на стартната позиција. Секој играч има различни стартни и крајни позиции и тие се маркирани сооедветно со неговата боја на таблата. Сите фигури кои се наоѓаат надвор од гаражата стануваат активни и притоа може да се движат соодветно со бројот добиен на коцката.  После секое добивање на број шест играчот има дозвола на уште едно фрлање или пак може да извади друга фигура на стартната позиција. Доколку постојат валидни потези играчот мора да го направи истиот, исто така доколку играчот ја помести фигурата на позиција каде што се наоѓа фигура со друга боја тој ја турка истата и таа се враќа во првобитната состојба т.е станува неактивна и се сместува во гаража. За невалиден потег се смета доколку на посакуваната позиција има веќе фигура со иста боја. Кога играчот ќе нема валидни потези редот оди на следниот играч и чека следно вртење. Кога еден играч ќе ги донесе сите фигури на крајните позиции играта завршува и тој победува.

### Опис на решението
Имплементацијата на играта се состои од две форми и една класа за играч. Првата форма која се појавува по стартување на апликацијата е формата за мени. Преку таа форма играчот може да одбере со која боја да игра и доколку сака може да игра против други играчи или пак против компјутерот. За да започне играта и да биде овозможено копчето старт е потребно да се селектираат барем две фигури. 

```
    // Prenesuvanje na argumeti za igracite vo glavnata strana
        private void btnStart_Click(object sender, EventArgs e)
        {
            ArrayList gameSettings = new ArrayList();
            gameSettings.Add(cbRed.Checked);
            gameSettings.Add(cbYellow.Checked);
            gameSettings.Add(cbGreen.Checked);
            gameSettings.Add(cbBlue.Checked);

            Boolean[] bots = new Boolean[4];
            settingBots(bots);
            Form game = new Game(gameSettings,bots);
            game.Show();
            this.Hide();
        }
```

За имплементација на играчите употребивме една класа. Во класата Player се чуваат информации за:
- Фигурите ( низа од копчиња)
- Уникатна патека за секој игра (низа int од 52 полиња)
- Позиција на секој од фигурите (низа int од 4 полиња)
- Состојбата на фигурите дали е активна или не (низа Boolean  од 4 полиња)
- Локација на сите позиции на мапата(низа од објект Point со 64 полиња)
- Локација на гаражите (низа од објект Point со 4 полиња)

```

        public Button[] figures { get; set; }           // vkupno 4 figuri
        public int[] pathBoard { get; set; }            // vkupno 52 polinja - patekata po koja se dvizi sekoj igrac poedinecno - 48 zaednicki polinja + 4 polinja od bazata
        public int[] positionBoard { get; set; }        // niza od 4 polina koja gi cuva poziciite na sekoja figura vo pathBoard
        public Boolean[] active { get; set; }           // niza od 4 polina koja pokazuva koja figura e izlezena od garazata
        Point[] board { get; set; }                     // vkupno 64 polinja --- site polinja na mapata
        Point[] garages { get; set; }                   // vkupno 4 garazi za sekoj igrac

        public Player(Button[] figures, int[]path, Point[] board, Point[] garages)
        {
            
            this.active = new Boolean[4];
            this.figures = new Button[4];
            this.positionBoard = new int[4];
            this.garages = new Point[4];

            for (int i = 0; i < 4; i++)
            {
                this.figures[i] = figures[i];
                positionBoard[i] = 0;
                active[i] = false;
                this.garages[i] = garages[i];
            }

            this.pathBoard = new int[52];
            for (int i = 0; i < 52; i++) {
                this.pathBoard[i] = path[i];
            }

            this.board = new Point[64];
            for (int i = 0; i < 64; i++)
            {
                this.board[i] = board[i];
            }
        }
```

Главната функција која овозможува движење на фигурите е функцијата moveFigure(int kocka, int figureNum). Враќа bool со цел да се одреди дали поместувањето било успешно. Како аргументи прима int kocka кој преставува бројот на коцката по добиеното вртење и int figureNum преку кое е се пренесува бројот на фигурата која сакаме да ја поместиме. Функцијата користи неколку помошни функции за проверка дали на стартната позиција има веќе фигура со иста боја и функција за проверка на преклопување на фигурите доколку се направи поместување.
```
       public bool moveFigure(int kocka, int figureNum) {
            //Postavuvane na pocetna pozicija ako ima 6 i figurata ne e aktivna
            //Ako e aktivna ja postavuva na soodvetnata pozicija
            //Vraka bool so cel da se utvrdi deka potegot bil uspesen
            if (kocka == 6 && active[figureNum] == false && !startTaken(figureNum))
            {
                active[figureNum] = true;
                figures[figureNum].Location = new Point(board[pathBoard[0]].X + 8, board[pathBoard[0]].Y + 4);
                return true;
            }
            else if (active[figureNum])
            {
                if (positionBoard[figureNum] + kocka <= 51 && !figuresOverlap(kocka, figureNum))
                {
                    positionBoard[figureNum] += kocka;
                    figures[figureNum].Location = new Point(getLocation(figureNum).X + 8, getLocation(figureNum).Y + 4);
                    return true;
                }  
            }
            return false;
        }
```


Втората форма или формата Game е главното платно каде што се игра играта. Во оваа форма најпрво се исцртува целата мапа и се поставува локацијата за секоја позиција. Во зависност од подесувањата на корисникот се поставуваат активните играчи на таблата. Играњето на играта во најголем дел се контролира со две копчиња како и фигурите кои се преставени со копчиња. Кога еден играч ќе дојде на ред тој прво мора да ја притисне со еден клик коцката со цел истата да се заврти а потоа со следниот клик ја стопира и добива резултат од вртењето. По завршувањето на вртењето на коцката фигурите на играчот се овозможуваат со што тој може да ги придвижи. Тука се прави и проверка доколку нема валидни потези се овозможува копчето за следен потег а доколку има валидни потези тој мора да го направи пред да продолжи со следниот потег.
```
 // Nastan pri klik na kocka
 private void buttonKocka_Click(object sender, EventArgs e)
        {
            if (kockaStartFlag)
            {
                timerKocka.Start();
                kockaStartFlag = false;
                diceRollSound.PlayLooping();
            }

            else
            {
                timerKocka.Stop();
                diceRollSound.Stop();
                kockaStartFlag = true;
                buttonKocka.Enabled = false;

                if (playersObjects[turnCounter] != null)
                {
                    playersObjects[turnCounter].figures[0].Enabled = true;
                    playersObjects[turnCounter].figures[1].Enabled = true;
                    playersObjects[turnCounter].figures[2].Enabled = true;
                    playersObjects[turnCounter].figures[3].Enabled = true;
                }

                if (kocka == 6)
                {
                    doubleTurn=true;
                }

                if (checkMoves(playersObjects[turnCounter]))
                { 
                    btnNextTurn.Enabled = false;
                }
                else if (kocka == 6 && checkAnyInactive(playersObjects[turnCounter]))
                {
                    btnNextTurn.Enabled = false;
                }
                else
                {
                    btnNextTurn.Enabled = true;
                }

                  
            }  
        }
```
Повикот за функцијата придвижување на фигурите се прави во функција за клик на  фигура. Доколку се придвижи фигурата се повикува и функција за туркање на друга фигура доколку на таа позиција се наоѓа друга фигура. Исто така се овозможува копчето за следен потег и се ресетира коцката.
```
 // Nastani za pridvizuvanje na kopcinjata
        // Red
        private void btnRed0_Click(object sender, EventArgs e)
        {
            if(playerRed.moveFigure(kocka, 0))
            {
                kickingPlayer(playerRed, 0);
                kocka = 0;
                btnNextTurn.Enabled = true;
                playerMovementSound.Play();
            }
            Invalidate();
        }
```
Во функцијата за клик на копчето за следен потег се прави проверка за двоен потег и исто така се поместува бројачот на ред до следниот активен играч. Исто така се доколку следниот играч што е на ред е игран од компјутерот се повикува соодветен метод за него.

```
       // Nastan pri klik na kopceto za next turn
        private void btnNextTurn_Click(object sender, EventArgs e)
        {
            if (!doubleTurn) { 
                if (playersObjects[turnCounter] != null)
                {
                    playersObjects[turnCounter].figures[0].Enabled = false;
                    playersObjects[turnCounter].figures[1].Enabled = false;
                    playersObjects[turnCounter].figures[2].Enabled = false;
                    playersObjects[turnCounter].figures[3].Enabled = false;
                }

                turnCounter++;

                if (turnCounter >= 4)
                {
                    turnCounter = 0;
                }

                while (playersObjects[turnCounter] == null) {
                    turnCounter++;
                    if (turnCounter >= 4)
                    {
                        turnCounter = 0;
                    }
                }

               
            }
            doubleTurn = false;
            buttonKocka.Enabled = true;
            btnNextTurn.Enabled = false;
            if (playersObjects[turnCounter] != null && bots[turnCounter] == true)
                botBehaviour();
            
        }
```

### Изглед и правила на игра

Првата и почетна форма која се отвара е формата за мени. Со клик на checkbox до секое од фигурите се активира иста и се отваара паѓачко мени преку кое се одбира дали да биде играно од играч или компјутер. Кога ќе има барем две фигури означено копчето за старт се овозможува и играта може да започне.

![menuform](https://user-images.githubusercontent.com/26025345/41463486-eeb6b3c4-7096-11e8-8e40-e624e23ae630.png)


Изгледот на главната форма е прикажан во следната слика. На десната од прозорецот под копчето за следен потег се прижува кој играч е на ред. Кога бојата на играчот која ја одбрал е активна тој со еден клик на коцката ја завртува а со следниот клик го добива резултат. Потоа доколку има валиден потед го прави тоа со клик на фигурата која сака да ја придвижи откако ќе биде завршен потегот се овозможува копчето за следен потег при што треба да биде кликнато со цел да му се овозможи игра на следниот играч кој е на ред.

![image](https://user-images.githubusercontent.com/26025345/41463716-bd85a28c-7097-11e8-8423-08b3432aa926.png)


Кога ќе има победник се појавува MessageBox и потоа играта се гаси.

![image](https://user-images.githubusercontent.com/26025345/41464052-0ea266c2-7099-11e8-8dd1-2fa860ec2f44.png)




