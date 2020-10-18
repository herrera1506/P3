using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimioAPI;
using SimioAPI.Extensions;

using SimioAPI.Graphics;
using Simio;
using Simio.SimioEnums;

namespace _MYS1_Practica3_P21
{
    class ApiSimio
    {
        private ISimioProject proyectoApi;
        private string rutabase = "[MYS1]ModeloBase_P21.spfx";
        private string rutafinal = "[MYS1]ModeloFinal_P21.spfx";
        private string[] warnings;
        private IModel model;
        private IIntelligentObjects intelligentObjects;
        private ILengthUnit lengthunits;       
        
        

        public ApiSimio()
        {
            proyectoApi = SimioProjectFactory.LoadProject(rutabase, out warnings);
            model = proyectoApi.Models[1];
            intelligentObjects = model.Facility.IntelligentObjects;                    
        }

        public void createModel()
        {
            createMap();
            SimioProjectFactory.SaveProject(proyectoApi, rutafinal, out warnings);

        }

        public void createMap()
        {
            createOutline();
            createZone();
            createCardinals();
            createAirpot();
        }

        public void createOutline()
        {
            createTransferNode(40, -95);
            updateName("TransferNode1", "TN1");
            createTransferNode(-20, -95);
            updateName("TransferNode1", "TN2");
            createConveyor(getNodobasico("TN1"), getNodobasico("TN2"));
            updateName("Conveyor1", "Mexico");
            updateProperty("Mexico", "DrawnToScale", "False");
            updateProperty("Mexico", "LogicalLength", "200000");
            model.Facility.IntelligentObjects["Mexico"].Properties["InitialDesiredSpeed"].Value = "16.66";
            //updateProperty("Mexico", "LogicalUnits", "Kilometers");
            createTransferNode(-20, -70);
            updateName("TransferNode1", "TN3");
            createConveyor(getNodobasico("TN2"), getNodobasico("TN3"));
            updateName("Conveyor1", "Mexico2");
            updateProperty("Mexico2", "DrawnToScale", "False");
            updateProperty("Mexico2", "LogicalLength", "90000");
            model.Facility.IntelligentObjects["Mexico2"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-40, -70);
            updateName("TransferNode1", "TN4");
            createConveyor(getNodobasico("TN3"), getNodobasico("TN4"));
            updateName("Conveyor1", "Mexico3");
            updateProperty("Mexico3", "DrawnToScale", "False");
            updateProperty("Mexico3", "LogicalLength", "62000");
            model.Facility.IntelligentObjects["Mexico3"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-13, -50);
            updateName("TransferNode1", "TN5");
            createConveyor(getNodobasico("TN4"), getNodobasico("TN5"));
            updateName("Conveyor1", "Mexico4");
            updateProperty("Mexico4", "DrawnToScale", "False");
            updateProperty("Mexico4", "LogicalLength", "130000");
            model.Facility.IntelligentObjects["Mexico4"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-5, -35);
            updateName("TransferNode1", "TN6");
            createConveyor(getNodobasico("TN5"), getNodobasico("TN6"));
            updateName("Conveyor1", "Mexico5");
            updateProperty("Mexico5", "DrawnToScale", "False");
            updateProperty("Mexico5", "LogicalLength", "30000");
            model.Facility.IntelligentObjects["Mexico5"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-53, -35);
            updateName("TransferNode1", "TN7");
            createConveyor(getNodobasico("TN6"), getNodobasico("TN7"));
            updateName("Conveyor1", "Mexico6");
            updateProperty("Mexico6", "DrawnToScale", "False");
            updateProperty("Mexico6", "LogicalLength", "180000");
            model.Facility.IntelligentObjects["Mexico6"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-68, -5);
            updateName("TransferNode1", "TN8");
            createConveyor(getNodobasico("TN7"), getNodobasico("TN8"));
            updateName("Conveyor1", "Mexico7");
            updateProperty("Mexico7", "DrawnToScale", "False");
            updateProperty("Mexico7", "LogicalLength", "120000");
            model.Facility.IntelligentObjects["Mexico7"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-63, 3);
            updateName("TransferNode1", "TN9");
            createConveyor(getNodobasico("TN8"), getNodobasico("TN9"));
            updateName("Conveyor1", "Mexico8");
            updateProperty("Mexico8", "DrawnToScale", "False");
            updateProperty("Mexico8", "LogicalLength", "30000");
            model.Facility.IntelligentObjects["Mexico8"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-65, 10);
            updateName("TransferNode1", "TN10");
            createConveyor(getNodobasico("TN9"), getNodobasico("TN10"));
            updateName("Conveyor1", "Mexico9");
            updateProperty("Mexico9", "DrawnToScale", "False");
            updateProperty("Mexico9", "LogicalLength", "20000");
            model.Facility.IntelligentObjects["Mexico9"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-53, 33);
            updateName("TransferNode1", "TN11");
            createConveyor(getNodobasico("TN10"), getNodobasico("TN11"));
            updateName("Conveyor1", "Mexico10");
            updateProperty("Mexico10", "DrawnToScale", "False");
            updateProperty("Mexico10", "LogicalLength", "100000");
            model.Facility.IntelligentObjects["Mexico10"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-28, 45);
            updateName("TransferNode1", "TN12");
            createConveyor(getNodobasico("TN11"), getNodobasico("TN12"));
            updateName("Conveyor1", "Pacifico");
            updateProperty("Pacifico", "DrawnToScale", "False");
            updateProperty("Pacifico", "LogicalLength", "150000");
            model.Facility.IntelligentObjects["Pacifico"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(-10, 43);
            updateName("TransferNode1", "TN13");
            createConveyor(getNodobasico("TN12"), getNodobasico("TN13"));
            updateName("Conveyor1", "Pacifico2");
            updateProperty("Pacifico2", "DrawnToScale", "False");
            updateProperty("Pacifico2", "LogicalLength", "54000");
            model.Facility.IntelligentObjects["Pacifico2"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(5, 47);
            updateName("TransferNode1", "TN14");
            createConveyor(getNodobasico("TN13"), getNodobasico("TN14"));
            updateName("Conveyor1", "Pacifico3");
            updateProperty("Pacifico3", "DrawnToScale", "False");
            updateProperty("Pacifico3", "LogicalLength", "50000");
            model.Facility.IntelligentObjects["Pacifico3"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(28, 35);
            updateName("TransferNode1", "TN15");
            createConveyor(getNodobasico("TN14"), getNodobasico("TN15"));
            updateName("Conveyor1", "ElSalvador");
            updateProperty("ElSalvador", "DrawnToScale", "False");
            updateProperty("ElSalvador", "LogicalLength", "150000");
            model.Facility.IntelligentObjects["ElSalvador"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(37, 20);
            updateName("TransferNode1", "TN16");
            createConveyor(getNodobasico("TN15"), getNodobasico("TN16"));
            updateName("Conveyor1", "ElSalvador2");
            updateProperty("ElSalvador2", "DrawnToScale", "False");
            updateProperty("ElSalvador2", "LogicalLength", "53000");
            model.Facility.IntelligentObjects["ElSalvador2"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(35, 10);
            updateName("TransferNode1", "TN17");
            createConveyor(getNodobasico("TN16"), getNodobasico("TN17"));
            updateName("Conveyor1", "Honduras");
            updateProperty("Honduras", "DrawnToScale", "False");
            updateProperty("Honduras", "LogicalLength", "20000");
            model.Facility.IntelligentObjects["Honduras"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(42, -3);
            updateName("TransferNode1", "TN18");
            createConveyor(getNodobasico("TN17"), getNodobasico("TN18"));
            updateName("Conveyor1", "Honduras2");
            updateProperty("Honduras2", "DrawnToScale", "False");
            updateProperty("Honduras2", "LogicalLength", "40000");
            model.Facility.IntelligentObjects["Honduras2"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(52, -5);
            updateName("TransferNode1", "TN19");
            createConveyor(getNodobasico("TN18"), getNodobasico("TN19"));
            updateName("Conveyor1", "Honduras3");
            updateProperty("Honduras3", "DrawnToScale", "False");
            updateProperty("Honduras3", "LogicalLength", "20000");
            model.Facility.IntelligentObjects["Honduras3"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(80, -20);
            updateName("TransferNode1", "TN20");
            createConveyor(getNodobasico("TN19"), getNodobasico("TN20"));
            updateName("Conveyor1", "Honduras4");
            updateProperty("Honduras4", "DrawnToScale", "False");
            updateProperty("Honduras4", "LogicalLength", "176000");
            model.Facility.IntelligentObjects["Honduras4"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(75, -30);
            updateName("TransferNode1", "TN21");
            createConveyor(getNodobasico("TN20"), getNodobasico("TN21"));
            updateName("Conveyor1", "Caribe");
            updateProperty("Caribe", "DrawnToScale", "False");
            updateProperty("Caribe", "LogicalLength", "10000");
            model.Facility.IntelligentObjects["Caribe"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(68, -23);
            updateName("TransferNode1", "TN22");
            createConveyor(getNodobasico("TN21"), getNodobasico("TN22"));
            updateName("Conveyor1", "Caribe2");
            updateProperty("Caribe2", "DrawnToScale", "False");
            updateProperty("Caribe2", "LogicalLength", "10000");
            model.Facility.IntelligentObjects["Caribe2"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(65, -32);
            updateName("TransferNode1", "TN23");
            createConveyor(getNodobasico("TN22"), getNodobasico("TN23"));
            updateName("Conveyor1", "Caribe3");
            updateProperty("Caribe3", "DrawnToScale", "False");
            updateProperty("Caribe3", "LogicalLength", "10000");
            model.Facility.IntelligentObjects["Caribe3"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(55, -20);
            updateName("TransferNode1", "TN24");
            createConveyor(getNodobasico("TN23"), getNodobasico("TN24"));
            updateName("Conveyor1", "Caribe4");
            updateProperty("Caribe4", "DrawnToScale", "False");
            updateProperty("Caribe4", "LogicalLength", "20000");
            model.Facility.IntelligentObjects["Caribe4"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(38, -15);
            updateName("TransferNode1", "TN25");
            createConveyor(getNodobasico("TN24"), getNodobasico("TN25"));
            updateName("Conveyor1", "Caribe5");
            updateProperty("Caribe5", "DrawnToScale", "False");
            updateProperty("Caribe5", "LogicalLength", "30000");
            model.Facility.IntelligentObjects["Caribe5"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(40, -25);
            updateName("TransferNode1", "TN26");
            createConveyor(getNodobasico("TN25"), getNodobasico("TN26"));
            updateName("Conveyor1", "Caribe6");
            updateProperty("Caribe6", "DrawnToScale", "False");
            updateProperty("Caribe6", "LogicalLength", "15000");
            model.Facility.IntelligentObjects["Caribe6"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(60, -35);
            updateName("TransferNode1", "TN27");
            createConveyor(getNodobasico("TN26"), getNodobasico("TN27"));
            updateName("Conveyor1", "Caribe7");
            updateProperty("Caribe7", "DrawnToScale", "False");
            updateProperty("Caribe7", "LogicalLength", "53000");
            model.Facility.IntelligentObjects["Caribe7"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createTransferNode(40, -35);
            updateName("TransferNode1", "TN28");
            createConveyor(getNodobasico("TN27"), getNodobasico("TN28"));
            updateName("Conveyor1", "Belice");
            updateProperty("Belice", "DrawnToScale", "False");
            updateProperty("Belice", "LogicalLength", "66000");
            model.Facility.IntelligentObjects["Belice"].Properties["InitialDesiredSpeed"].Value = "16.66";
            createConveyor(getNodobasico("TN28"), getNodobasico("TN1"));
            updateName("Conveyor1", "Belice2");
            updateProperty("Belice2", "DrawnToScale", "False");
            updateProperty("Belice2", "LogicalLength", "200000");
            model.Facility.IntelligentObjects["Belice2"].Properties["InitialDesiredSpeed"].Value = "16.66";

        }

        public void createZone()
        {
            //Server 
            createServer(0, 0);
            updateName("Server1", "Metropolitana");
            model.Facility.IntelligentObjects["Metropolitana"].Properties["ProcessingTime"].Value = "Random.Exponential(4)";
            model.Facility.IntelligentObjects["Output@Metropolitana"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            model.Facility.IntelligentObjects["Metropolitana"].Properties["InitialCapacity"].Value = "200";
            createServer(5, -20);
            updateName("Server1", "Norte");
            model.Facility.IntelligentObjects["Norte"].Properties["ProcessingTime"].Value = "Random.Exponential(5)";
            model.Facility.IntelligentObjects["Output@Norte"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            model.Facility.IntelligentObjects["Norte"].Properties["InitialCapacity"].Value = "50";
            createServer(30, -10);
            updateName("Server1", "NorOriente");
            model.Facility.IntelligentObjects["NorOriente"].Properties["ProcessingTime"].Value = "Random.Exponential(3)";
            model.Facility.IntelligentObjects["Output@NorOriente"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            model.Facility.IntelligentObjects["NorOriente"].Properties["InitialCapacity"].Value = "40";
            createServer(15, 20);
            updateName("Server1", "SurOriente");
            model.Facility.IntelligentObjects["SurOriente"].Properties["ProcessingTime"].Value = "Random.Exponential(4)";
            model.Facility.IntelligentObjects["Output@SurOriente"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            model.Facility.IntelligentObjects["SurOriente"].Properties["InitialCapacity"].Value = "30";
            createServer(-15, 20);
            updateName("Server1", "Central");
            model.Facility.IntelligentObjects["Central"].Properties["ProcessingTime"].Value = "Random.Exponential(5)";
            model.Facility.IntelligentObjects["Output@Central"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            model.Facility.IntelligentObjects["Central"].Properties["InitialCapacity"].Value = "100";
            createServer(-40, 10);
            updateName("Server1", "SurOccidente");
            model.Facility.IntelligentObjects["SurOccidente"].Properties["ProcessingTime"].Value = "Random.Exponential(3)";
            model.Facility.IntelligentObjects["Output@SurOccidente"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            model.Facility.IntelligentObjects["SurOccidente"].Properties["InitialCapacity"].Value = "120";
            createServer(-40, -20);
            updateName("Server1", "NorOccidente");
            model.Facility.IntelligentObjects["NorOccidente"].Properties["ProcessingTime"].Value = "Random.Exponential(6)";
            model.Facility.IntelligentObjects["Output@NorOccidente"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            model.Facility.IntelligentObjects["NorOccidente"].Properties["InitialCapacity"].Value = "30";
            createServer(10, -50);
            updateName("Server1", "Peten");
            model.Facility.IntelligentObjects["Peten"].Properties["ProcessingTime"].Value = "Random.Exponential(4)";
            model.Facility.IntelligentObjects["Output@Peten"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";
            model.Facility.IntelligentObjects["Peten"].Properties["InitialCapacity"].Value = "150";


            createSource(-4, -80);
            updateName("Source1", "FuerzaAerea");
            model.Facility.IntelligentObjects["FuerzaAerea"].Properties["MaximumArrivals"].Value = "15";
            model.Facility.IntelligentObjects["FuerzaAerea"].Properties["InterarrivalTime"].Value = "Random.Exponential(15)";


        }

        public void createCardinals()
        {
            createTransferNode(0, -100);
            updateName("TransferNode1", "PCNorte");
            createTransferNode(0, 70);
            updateName("TransferNode1", "PCSur");
            createTransferNode(-90, 0);
            updateName("TransferNode1", "PCOeste");
            createTransferNode(90, 0);
            updateName("TransferNode1", "PCEste");
        }

        public void createAirpot() {

            //Peten
            createSource(2, -54);
            updateName("Source1", "TuristasNacionalesPeten");
            model.Facility.IntelligentObjects["TuristasNacionalesPeten"].Properties["InterarrivalTime"].Value = "Random.Poisson(4)";

            createSource(2,-52);
            updateName("Source1", "TuristasInternacionalesPeten");
            model.Facility.IntelligentObjects["TuristasInternacionalesPeten"].Properties["InterarrivalTime"].Value = "Random.Exponential(50)";
            model.Facility.IntelligentObjects["TuristasInternacionalesPeten"].Properties["EntitiesPerArrival"].Value = "40";

            createSink(2, -47);
            updateName("Sink1", "AeropuertoSalidaP");

            createSink(10, -53);
            updateName("Sink1", "RetornoPeten");

            createTransferNode(6, -50);
            updateName("TransferNode1", "DecisionMundoMaya");
            model.Facility.IntelligentObjects["DecisionMundoMaya"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";

            //Nacionales
            createPath(getNodo("TuristasNacionalesPeten", 0), getNodo("Peten", 0));
            updateName("Path1", "NTuristasPeten");
            //Internacionales
            createPath(getNodo("TuristasInternacionalesPeten", 0), getNodo("Peten", 0));
            updateName("Path1", "ITuristasPeten");
            //Retorno a pente
            createPath(getNodo("Peten", 1), getNodo("RetornoPeten",0));
            updateName("Path1", "RPeten");
            model.Facility.IntelligentObjects["RPeten"].Properties["SelectionWeight"].Value = "0.5";

            //createPath(getNodobasico("RetornoPeten"), getNodobasico("DecisionMundoMaya"));
            //updateName("Path1", "RPeten2");
            //Salida del pais 
            createPath(getNodobasico("DecisionMundoMaya"), getNodo("AeropuertoSalidaP", 0));
            updateName("Path1", "SalidaPeten");
            model.Facility.IntelligentObjects["SalidaPeten"].Properties["SelectionWeight"].Value = "0.3";
            //retorno a info peten 
            createPath(getNodobasico("DecisionMundoMaya"), getNodo("Peten", 0));
            updateName("Path1", "RetornoInfoPeten");
            model.Facility.IntelligentObjects["RetornoInfoPeten"].Properties["SelectionWeight"].Value = "0.7";


            //Norte
            createSource(-2, -22);
            updateName("Source1", "TuristasNacionalesNorte");
            model.Facility.IntelligentObjects["TuristasNacionalesNorte"].Properties["InterarrivalTime"].Value = "Random.Poisson(8)";
            //source - server
            createPath(getNodo("TuristasNacionalesNorte", 0), getNodo("Norte", 0));
            updateName("Path1", "NTuristasNorte");

            createSink(5, -23);
            updateName("Sink1", "RetornoNorte");

            createTransferNode(3, -15);
            updateName("TransferNode1", "ResTNorte");
            
            
            createTransferNode(3, -32);
            updateName("TransferNode1", "SalidaNorteNorOccidente");

            //tranfert - input server
            //createPath(getNodobasico("RetornoNorte"), getNodo("Norte", 0));
            //updateName("Path1", "RNorte2");
            //output server - transfer
            createPath(getNodo("Norte", 1), getNodo("RetornoNorte",0));
            updateName("Path1", "RNorte1");
            model.Facility.IntelligentObjects["RNorte1"].Properties["SelectionWeight"].Value = "0.4";

            createPath(getNodobasico("ResTNorte"), getNodo("Norte", 0));
            updateName("Path1", "ResNorte1");

            createPath(getNodo("Norte", 1 ), getNodobasico("SalidaNorteNorOccidente"));
            updateName("Path1", "PSalidaNorteNorOccidente");
            model.Facility.IntelligentObjects["PSalidaNorteNorOccidente"].Properties["SelectionWeight"].Value = "0.1";



            //NorOccidente
            createSource(-48, -22);
            updateName("Source1", "TuristasNacionalesNorOccidente");
            model.Facility.IntelligentObjects["TuristasNacionalesNorOccidente"].Properties["InterarrivalTime"].Value = "Random.Poisson(12)";
            //source -server
            createPath(getNodo("TuristasNacionalesNorOccidente", 0), getNodo("NorOccidente", 0));
            updateName("Path1", "NTuristasNorOccidente");

            createSink(-40, -23);
            updateName("Sink1", "RetornoNorOccidente");

            //trasnfer - input server
            //createPath(getNodobasico("RetornoNorOccidente"), getNodo("NorOccidente", 0));
            //updateName("Path1", "RNorOccidente2");

            //output server -transerf 
            createPath(getNodo("NorOccidente", 1), getNodo("RetornoNorOccidente",0));
            updateName("Path1", "RNorOccidente");
            model.Facility.IntelligentObjects["RNorOccidente"].Properties["SelectionWeight"].Value = "0.40";



            //NorOriente
            createSource(18, -12);
            updateName("Source1", "TuristasNacionalesNorOriente");
            model.Facility.IntelligentObjects["TuristasNacionalesNorOriente"].Properties["InterarrivalTime"].Value = "Random.Poisson(6)";
            //source - server
            createPath(getNodo("TuristasNacionalesNorOriente", 0), getNodo("NorOriente", 0));
            updateName("Path1", "NTuristasNorOriente");

            createSink(30, -13);
            updateName("Sink1", "RetornoNorOriente");

            createTransferNode(16, -10);
            updateName("TransferNode1", "ResNorOriente");

            createTransferNode(31, -15);
            updateName("TransferNode1", "SalidaNorteNorOriente");

            createTransferNode(31, -7);
            updateName("TransferNode1", "SalidaMetropolintanaNorOriente");

            createTransferNode(22, 0);
            updateName("TransferNode1", "RetornoMetropolitanaNorOriente");


            createPath(getNodo("NorOriente", 1), getNodo("RetornoNorOriente",0));
            updateName("Path1", "RNorOriente");
            model.Facility.IntelligentObjects["RNorOriente"].Properties["SelectionWeight"].Value = "0.20";

            createPath(getNodobasico("ResNorOriente"), getNodo("NorOriente",0));
            updateName("Path1", "ResNorOriente");

            createPath(getNodo("NorOriente", 1), getNodobasico("SalidaNorteNorOriente"));
            updateName("Path2", "PathSalidaNorteNorOriente"); //path2
            model.Facility.IntelligentObjects["PathSalidaNorteNorOriente"].Properties["SelectionWeight"].Value = "0.15";

            createPath(getNodo("NorOriente", 1), getNodobasico("SalidaMetropolintanaNorOriente"));
            updateName("Path2", "ResNorOccidenteNorOriente");
            model.Facility.IntelligentObjects["ResNorOccidenteNorOriente"].Properties["SelectionWeight"].Value = "0.30";


            //SurOriente
            createSource(7, 18);
            updateName("Source1", "TuristasNacionalesSurOriente");
            model.Facility.IntelligentObjects["TuristasNacionalesSurOriente"].Properties["InterarrivalTime"].Value = "Random.Poisson(10)";

            createPath(getNodo("TuristasNacionalesSurOriente", 0), getNodo("SurOriente", 0));
            updateName("Path2", "NTuristasNorOriente");


            createSink(15, 23);
            updateName("Sink1", "RetornoSurOriente");

            createTransferNode(13, 14);
            updateName("TransferNode1", "MetroSurOriente");

            createTransferNode(0, 38);
            updateName("TransferNode1", "CentralSurOriente");

            //createPath(getNodobasico("RetornoSurOriente"), getNodo("SurOriente", 0));
            //updateName("Path3", "RSurOriente2"); //Path3

            createPath(getNodo("SurOriente", 1), getNodo("RetornoSurOriente",0));
            updateName("Path3", "RSurOriente");
            model.Facility.IntelligentObjects["RSurOriente"].Properties["SelectionWeight"].Value = "0.4";


            createPath(getNodobasico("MetroSurOriente"), getNodo("SurOriente", 0));
            updateName("Path3", "PMetroSurOriente");

            createPath(getNodo("SurOriente",1), getNodobasico("CentralSurOriente"));
            updateName("Path3", "SalidaCentralSurOriente");
            model.Facility.IntelligentObjects["SalidaCentralSurOriente"].Properties["SelectionWeight"].Value = "0.15";


            //Central
            createSource(-23, 19);
            updateName("Source1", "TuristasNacionalesCentral");
            model.Facility.IntelligentObjects["TuristasNacionalesCentral"].Properties["InterarrivalTime"].Value = "Random.Poisson(3)";

            createPath(getNodo("TuristasNacionalesCentral", 0), getNodo("Central", 0));
            updateName("Path1", "NTuristasCentral");

            createSink(-15, 23);
            updateName("Sink1", "RetornoCentral");

            createTransferNode(-15, 15);
            updateName("TransferNode1", "SalidaSurOccidenteCentral");

            //createPath(getNodobasico("RetornoCentral"), getNodo("Central", 0));
            //updateName("Path1", "RCentral2");

            createPath(getNodo("Central", 1), getNodo("RetornoCentral",0));
            updateName("Path1", "RCentral");
            model.Facility.IntelligentObjects["RCentral"].Properties["SelectionWeight"].Value = "0.35";

            createPath(getNodo("Central", 1), getNodobasico("SalidaSurOccidenteCentral"));
            updateName("Path1", "SalidaSurOccidenteCentral");

            //Sur Occidente

            createSource(-46, 5);
            updateName("Source1", "TuristasNacionalesSurOccidente");
            model.Facility.IntelligentObjects["TuristasNacionalesSurOccidente"].Properties["InterarrivalTime"].Value = "Random.Poisson(4)";

            createSource(-47, 7);
            updateName("Source1", "TuristasInternacionalesSurOccidente");
            model.Facility.IntelligentObjects["TuristasInternacionalesSurOccidente"].Properties["InterarrivalTime"].Value = "Random.Exponential(70)";
            model.Facility.IntelligentObjects["TuristasInternacionalesSurOccidente"].Properties["EntitiesPerArrival"].Value = "30";

            createSink(-46, 17);
            updateName("Sink1", "AeropuertoSalidaSurOccidente");

            createSink(-40, 7);
            updateName("Sink1", "RetornoSurOccidente");

            createTransferNode(-41, 15);
            updateName("TransferNode1", "RetornoCentralSurOccidente");

            createTransferNode(-44, 10);
            updateName("TransferNode1", "DecisionInternacionalQuetzaltenango");
            model.Facility.IntelligentObjects["DecisionInternacionalQuetzaltenango"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";

            createPath(getNodo("TuristasNacionalesSurOccidente", 0), getNodo("SurOccidente", 0));
            updateName("Path4", "NTuristasSurOccidente"); //path4

            createPath(getNodo("TuristasInternacionalesSurOccidente", 0), getNodo("SurOccidente", 0));
            updateName("Path4", "ITuristasSurOccidente");

            createPath(getNodo("SurOccidente", 1), getNodo("RetornoSurOccidente",0));
            updateName("Path4", "RSurOccidente");
            model.Facility.IntelligentObjects["RSurOccidente"].Properties["SelectionWeight"].Value = "0.35";

            //createPath(getNodobasico("RetornoSurOccidente"), getNodobasico("DecisionInternacionalQuetzaltenango"));
            //updateName("Path4", "RertornoDesicion");

            createPath(getNodobasico("DecisionInternacionalQuetzaltenango"), getNodo("AeropuertoSalidaSurOccidente",0));
            updateName("Path4", "SalidaInternacional");
            model.Facility.IntelligentObjects["SalidaInternacional"].Properties["SelectionWeight"].Value = "0.4";

            createPath(getNodobasico("DecisionInternacionalQuetzaltenango"), getNodo("SurOccidente", 0));
            updateName("Path4", "RetornoIngoSurOccidente");
            model.Facility.IntelligentObjects["RetornoIngoSurOccidente"].Properties["SelectionWeight"].Value = "0.6";

            createPath(getNodobasico("RetornoCentralSurOccidente"), getNodobasico("DecisionInternacionalQuetzaltenango"));
            updateName("Path4", "RetornoInfoCentralSurOccidente");


            //Metropolitana

            createSource(-8, 2);
            updateName("Source1", "TuristasNacionalesMetropolitana");
            model.Facility.IntelligentObjects["TuristasNacionalesMetropolitana"].Properties["InterarrivalTime"].Value = "Random.Poisson(2)";
            createSource(-8,4);
            updateName("Source1", "TuristasInternacionalesMetropolitana");
            model.Facility.IntelligentObjects["TuristasInternacionalesMetropolitana"].Properties["InterarrivalTime"].Value = "Random.Exponential(35)";
            model.Facility.IntelligentObjects["TuristasInternacionalesMetropolitana"].Properties["EntitiesPerArrival"].Value = "70";

            createSink(-8, -2);
            updateName("Sink1", "AeropuertoSalidaMetropolitana");

            createSink(0, -3);
            updateName("Sink1", "RetornoMetropolitana");

            createTransferNode(-1, -7);
            updateName("TransferNode1", "RetornoNorOrienteMetropolitana");

            createTransferNode(-13, 0);
            updateName("TransferNode1", "RetornoCentralMetropolitana");

            createTransferNode(-5, 0);
            updateName("TransferNode1", "DecisionLaAurora");
            model.Facility.IntelligentObjects["DecisionLaAurora"].Properties["OutboundLinkRule"].Value = "ByLinkWeight";

            createPath(getNodo("TuristasNacionalesMetropolitana", 0), getNodo("Metropolitana", 0));
            updateName("Path4", "NTuristasMetropolitana");

            createPath(getNodo("TuristasInternacionalesMetropolitana", 0), getNodo("Metropolitana", 0));
            updateName("Path4", "ITuristasMetropolitana");

            createPath(getNodo("Metropolitana", 1), getNodo("RetornoMetropolitana",0));
            updateName("Path4", "RMetropolitana");
            model.Facility.IntelligentObjects["RMetropolitana"].Properties["SelectionWeight"].Value = "0.35";

            //createPath(getNodobasico("RetornoMetropolitana"), getNodobasico("DecisionLaAurora"));
            //updateName("Path4", "RetornoMetropolitana");

            createPath(getNodobasico("DecisionLaAurora"), getNodo("AeropuertoSalidaMetropolitana", 0));
            updateName("Path4", "SalidaMetropolitana");
            model.Facility.IntelligentObjects["SalidaMetropolitana"].Properties["SelectionWeight"].Value = "0.5";

            createPath(getNodobasico("RetornoNorOrienteMetropolitana"), getNodobasico("DecisionLaAurora"));
            updateName("Path4", "RRetornoNorOrienteMetropolitana2");

            createPath(getNodobasico("RetornoCentralMetropolitana"), getNodobasico("DecisionLaAurora"));
            updateName("Path4", "PRetornoCentralMetropolitana");

            createPath(getNodobasico("DecisionLaAurora"), getNodo("Metropolitana", 0));
            updateName("Path4", "RetornoInfoMetropolitana");
            model.Facility.IntelligentObjects["RetornoInfoMetropolitana"].Properties["SelectionWeight"].Value = "0.5";


            //Caminos 

            //Peten
            createConveyor(getNodo("Peten", 1), getNodo("NorOriente", 0));
            updateName("Conveyor1", "PetenNorOriente");
            model.Facility.IntelligentObjects["PetenNorOriente"].Properties["SelectionWeight"].Value = "0.25";
            model.Facility.IntelligentObjects["PetenNorOriente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["PetenNorOriente"].Properties["LogicalLength"].Value = "282000";
            model.Facility.IntelligentObjects["PetenNorOriente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("Peten", 1), getNodo("Norte", 0));
            updateName("Conveyor1", "PetenNorte");
            model.Facility.IntelligentObjects["PetenNorte"].Properties["SelectionWeight"].Value = "0.25";
            model.Facility.IntelligentObjects["PetenNorte"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["PetenNorte"].Properties["LogicalLength"].Value = "147000";
            model.Facility.IntelligentObjects["PetenNorOriente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("FuerzaAerea", 0), getNodobasico("TN3"));
            updateName("Conveyor1", "FuerzaT3");

            //Norte
            createConveyor(getNodo("Norte", 1), getNodo("NorOriente", 0));
            updateName("Conveyor1", "NortenNorOriente");
            model.Facility.IntelligentObjects["NortenNorOriente"].Properties["SelectionWeight"].Value = "0.10";
            model.Facility.IntelligentObjects["NortenNorOriente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NortenNorOriente"].Properties["LogicalLength"].Value = "138000";
            model.Facility.IntelligentObjects["NortenNorOriente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodobasico("SalidaNorteNorOccidente"), getNodo("NorOccidente", 0));
            updateName("Conveyor1", "NorteNorOccidente");
            //model.Facility.IntelligentObjects["NorteNorOccidente"].Properties["SelectionWeight"].Value = "0.10";
            model.Facility.IntelligentObjects["NorteNorOccidente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NorteNorOccidente"].Properties["LogicalLength"].Value = "145000";
            model.Facility.IntelligentObjects["NorteNorOccidente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("Norte", 1), getNodobasico("DecisionMundoMaya"));
            updateName("Conveyor1", "NortePten");
            model.Facility.IntelligentObjects["NortePten"].Properties["SelectionWeight"].Value = "0.4";
            model.Facility.IntelligentObjects["NortePten"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NortePten"].Properties["LogicalLength"].Value = "147000";
            model.Facility.IntelligentObjects["NortePten"].Properties["InitialDesiredSpeed"].Value = "19.44";

            //NorOccidente
            createConveyor(getNodo("NorOccidente", 1), getNodo("Central", 0));
            updateName("Conveyor1", "NorOccidenteCentral");
            model.Facility.IntelligentObjects["NorOccidenteCentral"].Properties["SelectionWeight"].Value = "0.10";
            model.Facility.IntelligentObjects["NorOccidenteCentral"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NorOccidenteCentral"].Properties["LogicalLength"].Value = "269000";
            model.Facility.IntelligentObjects["NorOccidenteCentral"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("NorOccidente", 1), getNodobasico("DecisionInternacionalQuetzaltenango"));
            updateName("Conveyor1", "NorOccidenteSurOccidente");
            model.Facility.IntelligentObjects["NorOccidenteSurOccidente"].Properties["SelectionWeight"].Value = "0.30";
            model.Facility.IntelligentObjects["NorOccidenteSurOccidente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NorOccidenteSurOccidente"].Properties["LogicalLength"].Value = "87000";
            model.Facility.IntelligentObjects["NorOccidenteSurOccidente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("NorOccidente", 1), getNodo("Norte", 0));
            updateName("Conveyor1", "NorOccidenteNorte");
            model.Facility.IntelligentObjects["NorOccidenteNorte"].Properties["SelectionWeight"].Value = "0.20";
            model.Facility.IntelligentObjects["NorOccidenteNorte"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NorOccidenteNorte"].Properties["LogicalLength"].Value = "145000";
            model.Facility.IntelligentObjects["NorOccidenteNorte"].Properties["InitialDesiredSpeed"].Value = "19.44";

            //NorOriente
            createConveyor(getNodobasico("SalidaNorteNorOriente"), getNodobasico("ResTNorte"));
            updateName("Conveyor1", "NorOrienteNorte");
           // model.Facility.IntelligentObjects["NorOrienteNorte"].Properties["SelectionWeight"].Value = "0.15";
            model.Facility.IntelligentObjects["NorOrienteNorte"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NorOrienteNorte"].Properties["LogicalLength"].Value = "138000";
            model.Facility.IntelligentObjects["NorOrienteNorte"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodobasico("SalidaMetropolintanaNorOriente"), getNodobasico("RetornoNorOrienteMetropolitana"));
            updateName("Conveyor1", "NorOrienteMetropolitana");
            model.Facility.IntelligentObjects["NorOrienteMetropolitana"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NorOrienteMetropolitana"].Properties["LogicalLength"].Value = "241000";
            model.Facility.IntelligentObjects["NorOrienteMetropolitana"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("NorOriente", 1), getNodobasico("DecisionMundoMaya"));
            updateName("Conveyor1", "NorOrientePeten");
            model.Facility.IntelligentObjects["NorOrientePeten"].Properties["SelectionWeight"].Value = "0.30";
            model.Facility.IntelligentObjects["NorOrientePeten"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NorOrientePeten"].Properties["LogicalLength"].Value = "282000";
            model.Facility.IntelligentObjects["NorOrientePeten"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("NorOriente", 1), getNodo("SurOriente", 0));
            updateName("Conveyor1", "NorOrienteSurOriente");
            model.Facility.IntelligentObjects["NorOrienteSurOriente"].Properties["SelectionWeight"].Value = "0.05";
            model.Facility.IntelligentObjects["NorOrienteSurOriente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["NorOrienteSurOriente"].Properties["LogicalLength"].Value = "231000";
            model.Facility.IntelligentObjects["NorOrienteSurOriente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            //createPath(getNodobasico("RetornoMetropolitanaNorOriente"), getNodo("NorOriente",0));
            //updateName("Path1", "NorOrienteMetropolitana");
            //model.Facility.IntelligentObjects["NorOrienteMetropolitana"].Properties["SelectionWeight"].Value = "0.20";
            //model.Facility.IntelligentObjects["NorOrienteSurOriente"].Properties["DrownToScale"].Value = "False";
            //model.Facility.IntelligentObjects["NorOrienteSurOriente"].Properties["LoficalLength"].Value = "231";


            //SurOccidente
            createConveyor(getNodo("SurOccidente", 1), getNodo("Central", 0));
            updateName("Conveyor1", "SurOccidenteCentral"); //path5
            model.Facility.IntelligentObjects["SurOccidenteCentral"].Properties["SelectionWeight"].Value = "0.35";
            model.Facility.IntelligentObjects["SurOccidenteCentral"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["SurOccidenteCentral"].Properties["LogicalLength"].Value = "155000";
            model.Facility.IntelligentObjects["SurOccidenteCentral"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("SurOccidente", 1), getNodo("NorOccidente", 0));
            updateName("Conveyor1", "SurOccidenteOccidente");
            model.Facility.IntelligentObjects["SurOccidenteOccidente"].Properties["SelectionWeight"].Value = "0.30";
            model.Facility.IntelligentObjects["SurOccidenteOccidente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["SurOccidenteOccidente"].Properties["LogicalLength"].Value = "87000";
            model.Facility.IntelligentObjects["SurOccidenteOccidente"].Properties["InitialDesiredSpeed"].Value = "19.44";


            //SurOriente
            createConveyor(getNodo("SurOriente", 1), getNodobasico("ResNorOriente"));
            updateName("Conveyor1", "SurOrienteNorOriente");
            model.Facility.IntelligentObjects["SurOrienteNorOriente"].Properties["SelectionWeight"].Value = "0.20";
            model.Facility.IntelligentObjects["SurOrienteNorOriente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["SurOrienteNorOriente"].Properties["LogicalLength"].Value = "231000";
            model.Facility.IntelligentObjects["SurOrienteNorOriente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("SurOriente", 1), getNodobasico("DecisionLaAurora"));
            updateName("Conveyor1", "SurOrienteMetropolitana");
            model.Facility.IntelligentObjects["SurOrienteMetropolitana"].Properties["SelectionWeight"].Value = "0.25";
            model.Facility.IntelligentObjects["SurOrienteMetropolitana"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["SurOrienteMetropolitana"].Properties["LogicalLength"].Value = "124000";
            model.Facility.IntelligentObjects["SurOrienteMetropolitana"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodobasico("CentralSurOriente"), getNodo("Central",0));
            updateName("Conveyor1", "SurOrienteCentral");
            model.Facility.IntelligentObjects["SurOrienteCentral"].Properties["SelectionWeight"].Value = "0.15";
            model.Facility.IntelligentObjects["SurOrienteCentral"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["SurOrienteCentral"].Properties["LogicalLength"].Value = "154000";
            model.Facility.IntelligentObjects["SurOrienteCentral"].Properties["InitialDesiredSpeed"].Value = "19.44";

            //Central 
            createConveyor(getNodobasico("SalidaSurOccidenteCentral"), getNodobasico("RetornoCentralSurOccidente"));
            updateName("Conveyor1", "CentralSurOccidente");
            model.Facility.IntelligentObjects["CentralSurOccidente"].Properties["SelectionWeight"].Value = "0.15";
            model.Facility.IntelligentObjects["CentralSurOccidente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["CentralSurOccidente"].Properties["LogicalLength"].Value = "154000";
            model.Facility.IntelligentObjects["CentralSurOccidente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("Central",1), getNodobasico("RetornoCentralMetropolitana"));
            updateName("Conveyor1", "CentralMetropolitana");
            model.Facility.IntelligentObjects["CentralMetropolitana"].Properties["SelectionWeight"].Value = "0.35";
            model.Facility.IntelligentObjects["CentralMetropolitana"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["CentralMetropolitana"].Properties["LogicalLength"].Value = "63000";
            model.Facility.IntelligentObjects["CentralMetropolitana"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("Central", 1), getNodo("SurOriente",0));
            updateName("Conveyor1", "PCentralSurOriente");
            model.Facility.IntelligentObjects["PCentralSurOriente"].Properties["SelectionWeight"].Value = "0.05";
            model.Facility.IntelligentObjects["PCentralSurOriente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["PCentralSurOriente"].Properties["LogicalLength"].Value = "155000";
            model.Facility.IntelligentObjects["PCentralSurOriente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("Central", 1), getNodo("NorOccidente", 0));
            updateName("Conveyor1", "CentralNorOccidente");
            model.Facility.IntelligentObjects["CentralNorOccidente"].Properties["SelectionWeight"].Value = "0.10";
            model.Facility.IntelligentObjects["CentralNorOccidente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["CentralNorOccidente"].Properties["LogicalLength"].Value = "269000";
            model.Facility.IntelligentObjects["CentralNorOccidente"].Properties["InitialDesiredSpeed"].Value = "19.44";


            //Metropolitana

            createConveyor(getNodo("Metropolitana", 1), getNodobasico("RetornoMetropolitanaNorOriente"));
            updateName("Conveyor1", "MetropolitanaNorOriente");//path6
            model.Facility.IntelligentObjects["MetropolitanaNorOriente"].Properties["SelectionWeight"].Value = "0.20";
            model.Facility.IntelligentObjects["MetropolitanaNorOriente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["MetropolitanaNorOriente"].Properties["LogicalLength"].Value = "241000";
            model.Facility.IntelligentObjects["MetropolitanaNorOriente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("Metropolitana", 1), getNodobasico("MetroSurOriente"));
            updateName("Conveyor1", "MetropolitanaSurOriente");
            model.Facility.IntelligentObjects["MetropolitanaSurOriente"].Properties["SelectionWeight"].Value = "0.15";
            model.Facility.IntelligentObjects["MetropolitanaSurOriente"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["MetropolitanaSurOriente"].Properties["LogicalLength"].Value = "124000";
            model.Facility.IntelligentObjects["MetropolitanaSurOriente"].Properties["InitialDesiredSpeed"].Value = "19.44";

            createConveyor(getNodo("Metropolitana", 1), getNodo("Central", 0));
            updateName("Conveyor1", "MetropolitanaCentrall");
            model.Facility.IntelligentObjects["MetropolitanaCentrall"].Properties["SelectionWeight"].Value = "0.30";
            model.Facility.IntelligentObjects["MetropolitanaCentrall"].Properties["DrawnToScale"].Value = "False";
            model.Facility.IntelligentObjects["MetropolitanaCentrall"].Properties["LogicalLength"].Value = "63000";
            model.Facility.IntelligentObjects["MetropolitanaCentrall"].Properties["InitialDesiredSpeed"].Value = "19.44";




        }

        //-------------------Objetos-------------------//

        public void createSource(int x, int y)
        {
            this.createObject("Source", x, y);
        }

        public void createServer(int x, int y)
        {
            this.createObject("Server", x, y);
        }

        public void createSink(int x, int y)
        {
            this.createObject("Sink", x, y);
        }

        public void createTransferNode(int x, int y)
        {
            this.createObject("TransferNode", x, y);           
        }

        //----------------------------Enlaces----------------------------//
        public void createPath(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("Path", nodo1, nodo2);
            
        }
        /*
        public void createTimePath(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("TimePath", nodo1, nodo2);
        }
        */
        public void createConveyor(INodeObject nodo1, INodeObject nodo2)
        {
            this.createLink("Conveyor", nodo1, nodo2);
        }


        //---------------------------------- Crear objetos y enlaces ----------------------------------//
        public void createObject(String type, int x, int y)
        {
            intelligentObjects.CreateObject(type, new FacilityLocation(x, 0, y));
        }

        public void createLink(String type, INodeObject nodo1, INodeObject nodo2)
        {
            intelligentObjects.CreateLink(type, nodo1, nodo2, null);
            
            

        }



        //------------------------------------- Modificar propiedades --------------------------------//
        public void updateProperty(String name, String property, String value)
        {
            model.Facility.IntelligentObjects[name].Properties[property].Value = value;
            //model.Facility.IntelligentObjects[name].Properties[property]
        }

        //--------------------------------------- Modificar nombre  -----------------------------------//
        public void updateName(String oldName, String newName)
        {
            model.Facility.IntelligentObjects[oldName].ObjectName = newName;
        }

        //---------------------------------------- Obtener Nodo ----------------------------------------//
        public INodeObject getNodo(String name, int nodo)
        {
            return ((IFixedObject)model.Facility.IntelligentObjects[name]).Nodes[nodo];           
        }

        //---------------------------------- Obtener Nodo Basicos --------------------------------------//
        public INodeObject getNodobasico (String name)
        {
            return (INodeObject)model.Facility.IntelligentObjects[name];
        }

        //prueba 
    }
}
