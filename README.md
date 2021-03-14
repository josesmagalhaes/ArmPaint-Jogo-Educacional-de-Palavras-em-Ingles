# ArmPaint-Jogo-Educacional-de-Palavras-em-Ingles
Aprender um idioma não é apenas aprender gramática e memorizar verbos irregulares, e isso é especialmente verdade para crianças pequenas. Sabe-se que as crianças podem aprender um idioma implicitamente, ou seja, ouvindo-o e, mais importante, usando-o em situações reais.

Usar jogos é uma ótima maneira de permitir que as crianças pratiquem o idioma em um ambiente tranquilizador. Na maioria dos casos, eles usam o inglês sem se preocupar com sintaxe e gramática. Os professores de inglês sabem disso e usam jogos em sala de aula para incentivar seus alunos a usar e melhorar seu inglês.

As tecnologias de comunicação e informação (TICs) estão cada vez mais presentes em diversas áreas de atuação, e a educação é uma delas. Cada vez mais e mais escolas adotam essas tecnologias em seus ambientes educacionais. Sejam através de sistemas de gerenciamento, pontos eletrônicos, mídias em geral, ou em jogos eletrônicos como é o caso aqui citado, essas tecnologias adentram cada vez mais o ambiente escolar.

Pensando nisso, a proposta deste trabalho é apresentar um software feito em estilo game que pretende ajudar crianças a aprender vocabulários em inglês. A ideia foi criar um software em C# que se integre ao Paint, fazendo com que o aluno tenha de adivinhar o desenho do professor feito no Paint, contudo, suas fontes de escolha serão em inglês.

# O Projeto

O sistema foi batizado de ArmPaint. O programa consiste de uma tela simples, com espaço para inserir nome do aluno, e espaço para se colocar a opção de imagem escolhida pelo aluno. Com relação a botões, tem-se os botões principais de Salvar e Verificar os resultados anteriores e escolher palavra.; no lado direito, tem-se as 40 opções de desafios de palavras previamente salvas no banco de dados; no lado esquerdo, tem-se os botões com as 20 opções de dicas disponíveis para cada desafio.

Este software, visto que ainda está em sua versão 0.0.0.1 necessita do uso conjunto com o Paint do Windows, ou qualquer outro software de desenho. O uso deste programa consiste em desenhar algo no software de desenho e tentar adivinhar a imagem em um tempo pré-determinado de 35 segundos.

![1](https://user-images.githubusercontent.com/31749933/111072530-b5de6800-84b9-11eb-9953-235ec05f180c.png)


Cada desafio caracteriza-se por um objeto, imagem, fruta, animal, dentre outras opções, e ao ser escolhida, o sistema dá 20 dicas em inglês de cada palavra, o aluno vai selecionando e quando achar a que julgar correta, ele clica em Escolher Palavra, o resultado de eu acerto é dado na hora. A pontuação do aluno vai de acordo com a quantidade de segundos que restar para que o tempo se esgote.

Optou-se por usar o Paint da Microsoft por dois motivos: primeiramente ele é um aplicativo simples de manusear. Depois, pelo fato de na escola alvo, todos os computadores estarem equipados com Windows 10 _Education_, vindo com ele nativo em seu sistema. Contudo, caso haja a necessidade de usar este jogo com outros softwares de desenho também é possível, tais quais Inkscape, GIMP, Blender, Corel, dentre outros.

![2](https://user-images.githubusercontent.com/31749933/111072709-8419d100-84ba-11eb-848a-d77ada4377e2.png)

Ao final ele pode ainda salvar seus resultados e confrontar com os dos colegas que realizaram os desafios anteriormente. O banco de dados pode ainda ser atualizado à medida que o professor necessitar. Abaixo, um exemplo do diagrama do banco de dados usado no sistema. Um protótipo simples, contendo apenas duas tabelas.

![3](https://user-images.githubusercontent.com/31749933/111072713-87ad5800-84ba-11eb-9d0e-fb1a822c85fc.png)

# Especificações do Sistema

Professor
* Desenha a imagem

Estudantes
* Inicia o software;
* Seleciona as palavras;
* Verificar resultados.

# Instalação

Para instalar o sistema, basta baixar o arquivo `Instalador` e `Banco de dados`. O instalador pode ser instalado normalmente em qualquer máquina com Windows. O banco de dados, deve ser importado via `SQL Server Management Studio`.

*Mais detalhes podem ser conferidos na documentação do software.




