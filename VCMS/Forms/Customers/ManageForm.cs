﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCMS.Library.Models;
using MaterialSkin.Controls;


namespace VCMS.Forms.Customers
{
    public partial class ManageForm : MaterialForm
    {
        public OwnerModel owner { get; set; }
        public PetModel pet { get; set; }
        public ManageForm()
        {
            InitializeComponent();
            
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            sexCombobox.SelectedIndex = -1;
            breedCombobox.SelectedIndex = -1;
            birthdayDatepicker.StateCommon.Content.Color1 = Properties.Settings.Default.GlobalFontColor;
            birthdayDatepicker.StateCommon.Back.Color1 = Properties.Settings.Default.GlobalControlBack;
            speciesCombobox.SelectedIndex = -1;
            if (owner != null)
            {
                if(owner.FirstName == null)
                {
                    this.Text = "Add";
                    clientsInfoPanel.Visible = true;
                    patientsInfoPanel.Visible = true;
                    patientsInfoPanel.Top = 286;
                    this.Height = 555;
                }
                else
                    {
                    this.Text = "Edit";
                    firstNameTextbox.Text = owner.FirstName;
                    lastNameTextbox.Text = owner.LastName;
                    contactTextbox.Text = owner.Cellphone;
                    addressTextbox.Text = owner.Address;
                    clientsInfoPanel.Visible = true;
                    patientsInfoPanel.Visible = false;
                    patientsInfoPanel.Top = 286;
                    this.Height = 360;
                }
            }
            if (pet != null)
            {
                if(pet.Name != null)
                {
                    petNameTextbox.Text = pet.Name;
                    speciesCombobox.SelectedIndex = speciesCombobox.Items.IndexOf(pet.Species);
                    breedCombobox.SelectedIndex = breedCombobox.Items.IndexOf(pet.Breed);
                    birthdayDatepicker.Value = pet.Birthday;
                    colormarkingTextbox.Text = pet.ColorMarking;
                    sexCombobox.SelectedIndex = sexCombobox.Items.IndexOf(pet.Sex);
                }
                clientsInfoPanel.Visible = false;
                patientsInfoPanel.Visible = true;
                patientsInfoPanel.Top = 67;
                this.Height = 360;
            }
            
        }

        private void ContactTextbox_Enter(object sender, EventArgs e)
        {
            if (contactTextbox.Text.Trim() == String.Empty) contactTextbox.SelectionStart = 0;
        }

        private void ContactTextbox_Click(object sender, EventArgs e)
        {
            if(contactTextbox.Text.Trim() == String.Empty) contactTextbox.SelectionStart = 0;

        }

        private void SpeciesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] dogs = {"Afghan Hound","Afghan Shepherd","Aidi","Airedale Terrier","Akbash","Akita","Alano Español","Alaskan husky","Alaskan Klee Kai","Alaskan Malamute","Alaunt","Alopekis","Alpine Dachsbracke","Alpine Mastiff","Alpine Spaniel","American Akita","American Bulldog","American Cocker Spaniel","American English Coonhound","American Eskimo Dog","American Foxhound","American Hairless Terrier","American Pit Bull Terrier","American Staffordshire Terrier","American Water Spaniel","Anatolian Shepherd Dog","Andalusian Hound","Anglo-Français de Petite Vénerie","Appenzeller Sennenhund","Ariege Pointer","Ariegeois","Armant","Armenian Gampr dog","Artois Hound","Askal","Australian Cattle Dog","Australian Kelpie","Australian Shepherd","Australian Silky Terrier","Australian Stumpy Tail Cattle Dog","Australian Terrier","Austrian Black and Tan Hound","Austrian Pinscher","Azawakh","Barbet","Basenji","Basque Ratter","Basque Shepherd Dog","Basset Artésien Normand","Basset Bleu de Gascogne","Basset Fauve de Bretagne","Basset Griffon Vendéen, Grand","Basset Griffon Vendéen, Petit","Basset Hound","Bavarian Mountain Hound","Beagle","Beagle-Harrier","Bearded Collie","Beauceron","Bedlington Terrier","Belgian Shepherd Dog (Groenendael)","Belgian Shepherd Dog (Laekenois)","Belgian Shepherd Dog (Malinois)","Belgian Shepherd Dog (Tervuren)","Bergamasco Shepherd","Berger Blanc Suisse","Berger Picard","Bernese Mountain Dog","Bichon Frisé","Billy","Black and Tan Coonhound","Black and Tan Virginia Foxhound","Black Norwegian Elkhound","Black Russian Terrier","Black Mouth Cur","Bleu de Gascogne, Grand","Bleu de Gascogne, Petit","Bloodhound","Blue Heeler","Blue Lacy","Blue Paul Terrier","Blue Picardy Spaniel","Bluetick Coonhound","Boerboel","Bohemian Shepherd","Bolognese","Border Collie","Border Terrier","Borzoi","Bosnian Coarse-haired Hound","Boston Terrier","Bouvier des Ardennes","Bouvier des Flandres","Boxer","Boykin Spaniel","Bracco Italiano","Braque d'Auvergne","Braque du Bourbonnais","Braque du Puy","Braque Francais","Braque Saint-Germain","Brazilian Dogo","Brazilian Terrier","Briard","Briquet Griffon Vendéen","Brittany","Broholmer","Bruno Jura Hound","Bucovina Shepherd Dog","Bull and Terrier","Bull Terrier","Bull Terrier (Miniature)","Bulldog","Bullenbeisser","Bullmastiff","Bully Kutta","Burgos Pointer","Canaan Dog","Canadian Eskimo Dog","Cane Corso","Cantabrian Water Dog","Cão da Serra de Aires","Cão de Castro Laboreiro","Cão de Gado Transmontano","Cão Fila de São Miguel","Carolina Dog","Carpathian Shepherd Dog","Catahoula Leopard Dog","Catalan Sheepdog","Caucasian Shepherd Dog","Cavalier King Charles Spaniel","Central Asian Shepherd Dog","Cesky Fousek","Cesky Terrier","Chesapeake Bay Retriever","Chien Français Blanc et Noir","Chien Français Blanc et Orange","Chien Français Tricolore","Chien-gris","Chihuahua","Chilean Fox Terrier","Chinese Chongqing Dog","Chinese Crested Dog","Chinese Imperial Dog","Chinook","Chippiparai","Chow Chow","Cierny Sery","Cirneco dell'Etna","Clumber Spaniel","Collie, Rough","Collie, Smooth","Combai","Cordoba Fighting Dog","Coton de Tulear","Cretan Hound","Croatian Sheepdog","Cumberland Sheepdog","Curly-Coated Retriever","Cursinu","Czechoslovakian Wolfdog","Dalmatian","Dandie Dinmont Terrier","Danish-Swedish Farmdog","Deutsche Bracke","Doberman Pinscher","Dogo Argentino","Dogo Cubano","Dogue de Bordeaux","Drentse Patrijshond","Drever","Dunker","Dutch Shepherd","Dutch Smoushond","East European Shepherd","Elo","English Cocker Spaniel","English Foxhound","English Mastiff","English Setter","English Shepherd","English Springer Spaniel","English Toy Terrier (Black & Tan)","English Water Spaniel","English White Terrier","Entlebucher Mountain Dog","Estonian Hound","Estrela Mountain Dog","Eurasier","Eurohound","Fila Brasileiro","Finnish Hound","Finnish Lapphund","Finnish Spitz","Flat-Coated Retriever","Fox Terrier (Smooth)","Fox Terrier, Wire","French Brittany","French Bulldog","French Spaniel","Galgo Español","Galician Cattle Dog","Garafian Shepherd","Gascon Saintongeois","Georgian Shepherd Dog","German Longhaired Pointer","German Pinscher","German Roughhaired Pointer","German Shepherd Dog","German Shorthaired Pointer","German Spaniel","German Spitz","German Wirehaired Pointer","Giant Schnauzer","Glen of Imaal Terrier","Golden Retriever","Gordon Setter","Gran Mastín de Borínquen","Grand Anglo-Français Blanc et Noir","Grand Anglo-Français Blanc et Orange","Grand Anglo-Français Tricolore","Grand Griffon Vendéen","Great Dane","Great Pyrenees","Greater Swiss Mountain Dog","Greek Harehound","Greenland Dog","Greyhound","Griffon Bleu de Gascogne","Griffon Bruxellois","Griffon Fauve de Bretagne","Griffon Nivernais","Guatemalan Dogo","Hanover Hound","Hare Indian Dog","Harrier","Havanese","Hawaiian Poi Dog","Himalayan Sheepdog","Hokkaido","Hortaya Borzaya","Hovawart","Huntaway","Hygenhund","Icelandic Sheepdog","Indian pariah dog","Indian Spitz","Irish Red and White Setter","Irish Setter","Irish Terrier","Irish Water Spaniel","Irish Wolfhound","Istrian Coarse-haired Hound","Istrian Shorthaired Hound","Italian Greyhound","Jagdterrier","Jämthund","Japanese Chin","Japanese Spitz","Japanese Terrier","Kai Ken","Kangal Dog","Kanni","Karakachan Dog","Karelian Bear Dog","Karst Shepherd","Keeshond","Kerry Beagle","Kerry Blue Terrier","King Charles Spaniel","King Shepherd","Kintamani","Kishu Ken","Komondor","Kooikerhondje","Koolie","Korean Jindo","Kromfohrländer","Kumaon Mastiff","Kunming Wolfdog","Kurī","Kuvasz","Kyi-Leo","Labrador Retriever","Lagotto Romagnolo","Lakeland Terrier","Lancashire Heeler","Landseer","Lapponian Herder","Leonberger","Lhasa Apso","Lithuanian Hound","Löwchen","Mackenzie River Husky","Mahratta Greyhound","Majorca Ratter","Majorca Shepherd Dog","Maltese","Manchester Terrier","Maremma Sheepdog","McNab","Mexican Hairless Dog","Miniature Australian Shepherd","Miniature American Shepherd","Miniature Fox Terrier","Miniature Pinscher","Miniature Schnauzer","Miniature Shar Pei","Mioritic","Molossus","Molossus of Epirus","Montenegrin Mountain Hound","Moscow Watchdog","Moscow Water Dog","Mountain Cur","Mucuchies","Mudhol Hound","Mudi","Münsterländer, Large","Münsterländer, Small","Newfoundland","New Zealand Heading Dog","Norfolk Spaniel","Norfolk Terrier","Norrbottenspets","North Country Beagle","Northern Inuit Dog","Norwegian Buhund","Norwegian Elkhound","Norwegian Lundehund","Norwich Terrier","Nova Scotia Duck-Tolling Retriever","Old Danish Pointer","Old English Sheepdog","Old English Terrier","Old German Shepherd Dog","Old Time Farm Shepherd","Olde English Bulldogge","Otterhound","Pandikona Hunting Dog","Paisley Terrier","Papillon","Parson Russell Terrier","Patterdale Terrier","Pekingese","Perro de Presa Canario","Perro de Presa Mallorquin","Peruvian Hairless Dog","Phalène","Pharaoh Hound","Phu Quoc Ridgeback","Picardy Spaniel","Plummer Terrier","Plott Hound","Podenco Canario","Pointer","Poitevin","Polish Greyhound","Polish Hound","Polish Hunting Dog","Polish Lowland Sheepdog","Polish Tatra Sheepdog","Pomeranian","Pont-Audemer Spaniel","Poodle","Porcelaine","Portuguese Podengo","Portuguese Pointer","Portuguese Water Dog","Posavac Hound","Pražský Krysařík","Pudelpointer","Pug","Puli","Pumi","Pungsan Dog","Pyrenean Mastiff","Pyrenean Shepherd","Rajapalayam","Rampur Greyhound","Rastreador Brasileiro","Ratonero Bodeguero Andaluz","Ratonero Murciano de Huerta","Ratonero Valenciano","Rat Terrier","Redbone Coonhound","Rhodesian Ridgeback","Rottweiler","Russian Spaniel","Russian Toy","Russian Tracker","Russo-European Laika","Russell Terrier","Sabueso Español","Sabueso fino Colombiano","Saint-Usuge Spaniel","Sakhalin Husky","Saluki","Samoyed","Sapsali","Šarplaninac","Schapendoes","Schillerstövare","Schipperke","Standard Schnauzer","Schweizer Laufhund","Schweizerischer Niederlaufhund","Scotch Collie","Scottish Deerhound","Scottish Terrier","Sealyham Terrier","Segugio Italiano","Seppala Siberian Sleddog","Serbian Hound","Serbian Tricolour Hound","Seskar Seal Dog","Shar Pei","Shetland Sheepdog","Shiba Inu","Shih Tzu","Shikoku","Shiloh Shepherd","Siberian Husky","Silken Windhound","Sinhala Hound","Skye Terrier","Sloughi","Slovak Cuvac","Slovakian Rough-haired Pointer","Slovenský Kopov","Smålandsstövare","Small Greek Domestic Dog","Soft-Coated Wheaten Terrier","South Russian Ovcharka","Southern Hound","Spanish Mastiff","Spanish Water Dog","Spinone Italiano","Sporting Lucas Terrier","St. Bernard","St. John's water dog","Stabyhoun","Staffordshire Bull Terrier","Stephens Cur","Styrian Coarse-haired Hound","Sussex Spaniel","Swedish Lapphund","Swedish Vallhund","Taigan","Taiwan Dog","Talbot","Tamaskan Dog","Teddy Roosevelt Terrier","Telomian","Tenterfield Terrier","Terceira Mastiff","Thai Bangkaew Dog","Thai Ridgeback","Tibetan Mastiff","Tibetan Spaniel","Tibetan Terrier","Tornjak","Tosa","Toy Bulldog","Toy Fox Terrier","Toy Manchester Terrier","Toy Trawler Spaniel","Transylvanian Hound","Treeing Cur","Treeing Tennessee Brindle","Treeing Walker Coonhound","Trigg Hound","Tweed Water Spaniel","Tyrolean Hound","Uruguayan Cimarron","Valencian Ratter","Vanjari Hound","Villano de Las Encartaciones","Vizsla","Volpino Italiano","Welsh Corgi, Cardigan","Welsh Corgi, Pembroke","Welsh Sheepdog","Welsh Springer Spaniel","Welsh Terrier","West Highland White Terrier","West Siberian Laika","Westphalian Dachsbracke","Wetterhoun","Whippet","White Shepherd","Wirehaired Pointing Griffon","Wirehaired Vizsla"};
            string[] cats = { "Abyssinian", "Aegean", "American Curl", "American Bobtail", "American Shorthair", "American Wirehair", "Arabian Mau", "Australian Mist", "Asian", "Asian Semi-longhair", "Balinese", "Bambino", "Bengal", "Birman", "Bombay", "Brazilian Shorthair", "British Semi-longhair", "British Shorthair", "British Longhair", "Burmese", "Burmilla", "California Spangled", "Chantilly-Tiffany", "Chartreux", "Chausie", "Cheetoh", "Colorpoint Shorthair", "Cornish Rex", "Cymric", "Cyprus", "Devon Rex", "Donskoy", "Dragon Li", "Dwarf cat", "Egyptian Mau", "European Shorthair", "Exotic Shorthair", "Foldex", "German Rex", "Havana Brown", "Highlander", "Himalayan", "Japanese Bobtail", "Javanese", "Karelian Bobtail", "Khao Manee", "Korat", "Korean Bobtail", "Korn Ja", "Kurilian Bobtail", "LaPerm", "Lykoi", "Maine Coon", "Manx", "Mekong Bobtail", "Minskin", "Munchkin", "Nebelung", "Napoleon", "Norwegian Forest cat", "Ocicat", "Ojos Azules", "Oregon Rex", "Oriental Bicolor", "Oriental Shorthair", "Oriental Longhair", "PerFold", "Persian (Modern Persian Cat)", "Persian (Traditional Persian Cat)", "Peterbald", "Pixie-bob", "Raas", "Ragamuffin", "Ragdoll", "Russian Blue", "Russian White, Black and Tabby", "Sam Sawet", "Savannah", "Scottish Fold", "Selkirk Rex", "Serengeti", "Serrade petit", "Siamese", "Siberian", "Singapura", "Snowshoe", "Sokoke", "Somali", "Sphynx", "Suphalak", "Thai", "Thai Lilac", "Tonkinese", "Toyger", "Turkish Angora", "Turkish Van", "Ukrainian Levkoy" };
            breedCombobox.Items.Clear();
            if (speciesCombobox.SelectedIndex == 0)
                foreach (var item in dogs)
                    breedCombobox.Items.Add(item);
            else
                foreach (var item in cats)
                    breedCombobox.Items.Add(item);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
