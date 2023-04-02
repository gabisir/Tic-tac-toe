namespace Tic_tac_toe;

public partial class MainPage : ContentPage
{
	int count = 0;//0->x  1->y
	int playfield = 0;//racunamo u mainu u kojoj se sekciji nalazi kliknut gumb od 1 do 9  !!!!!   OVO JE MOZDA NEPOTREBNO  !!!!!
	int playfield_required = 0; // definiramo di ce igrac morat igrat isto od 1 do 9 ali ako moze svugdje onda je 0
	int illegal = 0;//zastavica koja se stavi na 1 ako je ilegalno
	public MainPage()
	{
		InitializeComponent();
	}

	//TODO: https://stackoverflow.com/questions/70797331/how-to-create-a-single-click-event-for-multiple-buttons-in-net-maui, POGLEDAJ TO DA NAPRAVIS 1 EVENT LISTENER ZA SVE GUMBE
	//TODO: IMAS JOS I EMPTY.SVG KOJI MORAS POSTAVIT NA SVAKI GUMB, TO JE SAMO PRAZAN FILE, ALI NEKI SOURCE MORA BITI NA GUMBU
	//TODO: SLIKE SU TI U Resources>Images FODLERU, I JOS IMAS ASSETS FOLDER SA ORIGINALIMA AKO NESTO SJEBES

	private void EventClickedHandler(object sender, EventArgs e)
	{
		var button = (ImageButton)sender;
		var classId = button.ClassId;
		// This will give you the value / classId of your button which you'll press
        
		if (button.Source.ToString() != "File: empty.png") //provjerava jel na gumbu prazna slika ispisivo sam button.source is skonto sve
        {
            DisplayAlert("Alert", "You made an illegal move", "OK");
            illegal = 1;
        }
        
		//provjerava u kojoj se sekciji nalazi kliknut gumb
        if (classId[0] <= '3' && classId[1] <= '3') { playfield = 1; }
		if (classId[0] <= '3' && classId[1] > '3' && classId[1] <= '6') { playfield = 2; }
		if (classId[0] <= '3' && classId[1] > '6' && classId[1] <= '9') { playfield = 3; }
		if (classId[0] > '3' && classId[0] <= '6' && classId[1] <= '3') { playfield = 4; }
		if (classId[0] > '3' && classId[0] <= '6' && classId[1] > '3' && classId[1] <= '6') { playfield = 5; }
		if (classId[0] > '3' && classId[0] <= '6' && classId[1] > '6' && classId[1] <= '9') { playfield = 6; }
		if (classId[0] > '6' && classId[0] <= '9' && classId[1] <= '3') { playfield = 7; }
		if (classId[0] > '6' && classId[0] <= '9' && classId[1] > '3' && classId[1] <= '6') { playfield = 8;}
		if (classId[0] > '6' && classId[0] <= '9' && classId[1] > '6' && classId[1] <= '9') { playfield = 9; }
      
        if (count == 0 && illegal==0)
		{
			count = 1;
			button.Source = "kruzic.png";
		}
		else if (count == 1 && illegal == 0)
		{
			count = 0;
			button.Source = "krizic.png";
		}
		illegal = 0;
    }
}

