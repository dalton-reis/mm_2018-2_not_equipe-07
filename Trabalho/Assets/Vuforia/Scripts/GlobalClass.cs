using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalClass 
{

    public int pontuacao = 0;
    public Dictionary<string, bool> insetosVistos = new Dictionary<string, bool>();
    public Dictionary<string, bool> respostas = new Dictionary<string, bool>();
    public int qtdInsetos = 6;
    public string ultimoVisto = "";
    public string botaoAtivo = "";
    public enum StatusJOGO{ INICIADO,FIMDEJOGO}
   
    public StatusJOGO statusAtual = StatusJOGO.INICIADO; 

    private static GlobalClass instance;

    public Dictionary<string, ArrayList> arrObjPergunta = new Dictionary<string, ArrayList>();

    public void popularPerguntas(){
        ArrayList arr = new ArrayList();
        arr.Add("São insetos diurnos que apresentam em \n" +
            "sua estrutura cabeça, tórax e abdômen, um \n" +
            "par de antenas, três pares de patas, e \n" +
            "também asas. A borboleta passa por fases em\n" +
            " sua vida, começando pelo ovo, larva, lagarta,\n" +
            " casulo e por último após a metamorfose, a \n" +
            "borboleta, que costuma ter uma vida curta, \n" +
            "durando entre 2 a 6 semanas. É importante \n" +
            "ressaltar que as borboletas fazem parte de \n" +
            "um grupo distinto das mariposas.");
        arr.Add("A borboleta tem a função de polinizar,\n" +
                " elas fazem isso involuntariamente ao \n" +
                "se alimentar do pólen das flores.");
        arr.Add("A borboleta e a mariposa fazem parte do\n" +
                " mesmo grupo de insetos?");
        arr.Add(false);
        arrObjPergunta.Add("borboleta",arr);

        arr = new ArrayList();
        arr.Add("A joaninha é um tipo de besouro, há cerca \n" +
                "de 6.000 espécies conhecidas. São dotadas \n" +
                "de corpo esférico quitinoso composto por \n" +
                "cabeça pequena, seis patas curtas, antenas\n" +
                " e dois pares de asas bem desenvolvidas, \n" +
                "podem medir até 1 centímetro e possuem as \n" +
                "mais variadas cores, de acordo com a espécie,\n" +
                " pode apresentar pintas na carapaça. São \n" +
                "geralmente predadoras - embora algumas \n" +
                "espécies se alimentem de plantas. A cada \n" +
                "ciclo reprodutivo a fêmea pode colocar de 10 \n" +
                "a mais de 1.000 ovos.");
        arr.Add("Estes animais são considerados controladores \n" +
            "naturais, uma vez que se alimentam de pragas \n" +
            "agrícolas como pulgões e cochonilhas. Uma única \n" +
            "joaninha pode comer mais de 50 pulgões por dia.");
        arr.Add("As joaninhas fingem-se de morta quando assustadas?");
        arr.Add(true);
        arrObjPergunta.Add("joaninha", arr);

        arr = new ArrayList();
        arr.Add("Corpo fusiforme, com o abdómen muito alongado\n" +
            ", olhos compostos e dois pares de asas semitransparentes\n" +
            ". Libélulas adultas caçam se baseando no sentido \n" +
            "da visão extremamente apurada, onde seus olhos são \n" +
            "compostos por milhares de facetas e têm um campo \n" +
            "visual de 360 graus. Medem entre 2 e 19 cm de \n" +
            "envergadura e as espécies mais rápidas podem voar \n" +
            "a cerca de 85 km/h. Mesmo possuindo seis pernas, \n" +
            "praticamente não consegue andar com elas. Seu tempo \n" +
            "de vida pode chegar a 5 anos, sendo que fase adulta \n" +
            "é somente de 2 meses. Aqui no Brasil existem cerca \n" +
            "de 1.200 espécies de um total 5.000 existentes no mundo.");
        arr.Add("Alimentam-se de moscas, besouros, abelhas, \n" +
            "vespas e outros insetos que capturam com bastante \n" +
            "habilidade e devoram com notável rapidez. Muitas\n" +
            " vezes, outras libélulas são tidas como presas.\n" +
            " Podem comer a presa enquanto voam ou podem posar\n" +
            " para comer. Normalmente, só aceitam presas que \n" +
            "se movem mas, se capturados e mantidos em cativeiro\n" +
            ", podem comer qualquer coisa, inclusive o próprio abdome.");
        arr.Add("As Libélulas chegam a viver até oito anos?");
        arr.Add(false);
        arrObjPergunta.Add("libelula", arr);

        arr = new ArrayList();
        arr.Add("As moscas pertencem à classe dos Insetos. \n" +
            "As características desse grupo são: divisão do \n" +
            "corpo em cabeça, tórax e abdome e presença de 3 \n" +
            "pares de patas. Na maioria dos casos apresentam \n" +
            "asas. Conhece - se aproximadamente 120.000 \n" +
            "espécies de dípteros e estima - se que existam \n" +
            "mais 1 milhão de espécies viventes. As moscas \n" +
            "vivem em média no Maximo 30 dias.");
        arr.Add("As moscas em geral ocupam diversos papéis \n" +
            "no ecossistema. As mais conhecidas como a \n" +
            "mosca-doméstica ou a mosca-varejeira, reciclam \n" +
            "matéria orgânica de origem animal: as fêmeas botam \n" +
            "ovos sobre substâncias orgânicas em decomposição, \n" +
            "esses ovos se desenvolvem em larvas que se \n" +
            "alimentam do substrato, então transformam-se em \n" +
            "pupa e, alguns dias depois, emergem como adultos.");
        arr.Add("O período de existência de uma mosca dura um ano?");
        arr.Add(false);
        arrObjPergunta.Add("mosca", arr);

        arr = new ArrayList();
        arr.Add("Possuem dois pares de asas, as anteriores são \n" +
            "maiores do que as posteriores. Possuem ferrão para \n" +
            "uso em caso de defesa, principalmente do ninho. \n" +
            "A picada também é um recurso de defesa para afastar \n" +
            "os predadores. As vespas adultas se alimentam de \n" +
            "néctar das flores de plantas. As que estão no ninho\n" +
            ", que nasceram a pouco tempo, se alimentam de insetos \n" +
            "pegos pelas vespas obreiras. Possuem ferrão para uso \n" +
            "em caso de defesa, principalmente do ninho. A picada \n" +
            "também é um recurso de defesa para afastar os predadores.");
        arr.Add("Existem mais de 75.000 espécies de vespas em todo \n" +
            "o mundo. As vespas são insetos benéficos para o \n" +
            "ambiente, tendo funções polinizadoras e são também \n" +
            "predadoras de pragas como algumas lagartas. O problema \n" +
            "surge quando elas constroem os ninhos ou se alimentam\n" +
            ", nas imediações de edifícios com ocupação humana. \n" +
            "Quando se sentem ameaçadas, podem desferir picadas \n" +
            "intensas e dolorosas, que podem ser muito graves caso \n" +
            "a pessoa picada seja alérgica.");
        arr.Add("Todas suas quatro asas são do mesmo tamanho?");
        arr.Add(false);
        arrObjPergunta.Add("vespa", arr);

        arr = new ArrayList();
        arr.Add("A barata costuma ficar em locais quentes e \n" +
            "úmidos que são as redes de esgoto, terrenos \n" +
            "abandonados e locais com muito lixo e sujeira. \n" +
            "Entram nas casas em busca de restos de comidas. \n" +
            "Nas florestas elas costumam se esconder embaixo de \n" +
            "pedras ou dentro dos cascos das árvores e no \n" +
            "período noturno saem em busca de comida e de parceiros \n" +
            "para sua reprodução, sendo que a mesma é sexuada e \n" +
            "elas geram os ovos. A fêmea possui um corpo maior \n" +
            "que o do macho. Existem mais de 4 mil espécies de \n" +
            "baratas em todo o mundo, sendo que a maioria das \n" +
            "espécies possuem seis pernas, um par de asas e \n" +
            "duas antenas.");
        arr.Add("Alimenta-se de restos de animais e faz \n" +
            "reciclagem de matéria orgânica em decomposição, \n" +
            "além disso, serve de alimento para pássaros, \n" +
            "lagartos, cobras e outros bichos.");
        arr.Add("Uma barata pode sobreviver por vários dias \n" +
            "sem a cabeça e, se perder uma das patas, ela \n" +
            "consegue se regenerar em poucos dias?");
        arr.Add(true);
        arrObjPergunta.Add("barata", arr);

    }

    public static GlobalClass Instance()
    {
        // Here we use the ?? operator, to return 'instance' if 'instance' does not equal null
        // otherwise we assign instance to a new component and return that
        if(instance == null) { 
           instance = new GlobalClass();
           instance.popularPerguntas();
        }
        
        return instance;
    }

    public string mostrarVistos()
    {
        string vistos = "";
        foreach (KeyValuePair<string, bool> entry in this.insetosVistos) {
            vistos += " "+entry.Key;
        }

        return vistos;
    }

    public int respostasAcertas() {

        int total = 0;
        foreach (KeyValuePair<string, bool> entry in this.respostas)
        {
            ArrayList arr;
            Debug.Log("Comparando"+ entry.Key);
            this.arrObjPergunta.TryGetValue(entry.Key, out arr);
            if ((bool)arr[3] == (bool)entry.Value) {
                total++;
            }
        }

        return total;
    }

    public string caracteristica;
    public string funcoes;
    public string perguntas;

    public void getString(string btnString){

        if(this.ultimoVisto != ""){

            ArrayList arrStr;
            this.arrObjPergunta.TryGetValue(this.ultimoVisto.ToLower(), out arrStr);

            this.perguntas = (string)arrStr[2];
            this.caracteristica = (string)arrStr[0];
            this.funcoes = (string)arrStr[1];

        }
    }

    public Dictionary<string, bool> retornaRespostas()
    {
        return this.respostas;
    }


    public void insertInseto(string inseto)
    {

        Debug.Log("INSERT Inseto:" +inseto);
        // endGame();
        

        if (!this.isInsetoInserido(inseto))
            this.insetosVistos.Add(inseto, true);
        this.ultimoVisto = inseto.ToLower();
        getString("");

    }

    public bool isInsetoInserido(string inseto)
    {
        return this.insetosVistos.ContainsKey(inseto);
    }

    public void insertResposta(string inseto, bool resposta)
    {
        Debug.Log("INSERTORESPOSTA");

        if (!this.isRespostaInserida(inseto))
            this.respostas.Add(inseto, resposta);

        Debug.Log("QTD DE INSETOS:"+insetosVistos.Count);

        //se todos os insetos foram Vistos, a resposta é do ultimo inseto restante, logo é o ultimo inseto visto então o jogo deve ser finalizado
        if (respostas.Count == qtdInsetos)
        {
            endGame();

        }
    }

    public bool isRespostaInserida(string inseto)
    {
        return this.respostas.ContainsKey(inseto);
    }

    public int getQtdAcertos()
    {
        int qtdacertos = 0;
        foreach (var obj in respostas)
        {
            if (obj.Value)
            {
                qtdacertos++;
            }
        }
                return qtdacertos;
    }

    public void endGame()
    {
        statusAtual = StatusJOGO.FIMDEJOGO;
        Debug.Log("~~~~endgame~~");
        float PosicaoX = -15;
        foreach (var obj in respostas)
        {
            if (obj.Value)
            {
                string NomeAcertado = obj.Key;
                string NomeObjeto = "";
                NomeAcertado.ToLower();

                switch (NomeAcertado)
                {
                    case "borboleta":
                        NomeObjeto = "ButterflyColor1";
                        break;
                    case "mosca":
                        NomeObjeto = "FlyColor1";
                        break;
                    case "vespa":
                        NomeObjeto = "WaspColor1";
                        break;
                    case "libelula":
                        NomeObjeto = "CockroachColor1";
                        break;
                    case "joaninha":
                        NomeObjeto = "LadyBugColor1";
                        break;
                    case "barata":
                        NomeObjeto = "CockroachColor1";
                        break;
                }
                GameObject insetoObject = Resources.Load<GameObject>(NomeObjeto);
                Vector3 position = Vector3.zero;
                Quaternion rotation = Quaternion.identity;
                Debug.Log("Acertado:" + NomeAcertado + NomeObjeto);

                float posicaoZ = 60;
                //int qtdInsetos = 3;
                //  posicaoZ = (qtdInsetos * posicaoZ )/ 6;
                Debug.Log(posicaoZ);

                position.z = posicaoZ;
                position.x = PosicaoX;
                position.y = -10;
                //pos.y = 10;            
                rotation.y = 175;
                rotation.z = -70;
                //insetoObject.
                Object.Instantiate(insetoObject, position, rotation);
                PosicaoX += 7;
            }
                    

        }
        //GuiQuadro quadro = new GuiQuadro(new Vector2(50, 50), new Vector2(200, 200), "Fim de Jogo!", "=szhjfuyjfyj6tjuyt");
       // quadro.MontaQuadro();
        // quadro.;


    }

    public void  ResetaMundO()
    {

    pontuacao = 0;
    insetosVistos = new Dictionary<string, bool>();
    respostas = new Dictionary<string, bool>();
    qtdInsetos = 6;
    ultimoVisto = "";
    botaoAtivo = "";
        statusAtual = StatusJOGO.INICIADO;

}

}


