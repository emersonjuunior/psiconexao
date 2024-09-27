# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER (Projeto Conceitual)

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Sugestão de ferramentas para geração deste artefato: LucidChart e Draw.io.

A referência abaixo irá auxiliá-lo na geração do artefato “Modelo ER”.

> - [Como fazer um diagrama entidade relacionamento | Lucidchart](https://www.lucidchart.com/pages/pt/como-fazer-um-diagrama-entidade-relacionamento)

## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
Para mais informações, consulte o microfundamento "Modelagem de Dados".

## Tecnologias Utilizadas
### Linguagens:
Para o desenvolvimento do projeto PsiConexão, utilizamos as seguintes linguagens:
- **HTML**: para a estrutura do front-end.
- **CSS**: para o design e estilização da interface.
- **JavaScript**: para a criação de interações dinâmicas no front-end.
- **C#**: para o desenvolvimento do back-end, garantindo a lógica de negócio e a manipulação dos dados.
### Serviços Web:
O site está hospedado via **GitHub Pages**, uma solução gratuita e eficaz para hospedar sites estáticos diretamente a partir de um repositório GitHub.
### Frameworks:
- **ASP.NET**: foi escolhido como framework para o desenvolvimento de aplicações web dinâmicas, permitindo a criação de um ambiente robusto e escalável.
### Bibliotecas:
- **.NET**: plataforma escolhida para a base do projeto, oferecendo suporte a múltiplas tecnologias e garantindo a performance necessária.
### IDEs de Desenvolvimento:
O **Visual Studio** foi a ferramenta de desenvolvimento escolhida devido à sua integração completa com o GitHub, facilitando o desenvolvimento e o controle de versão.
### Ferramentas:
Para o controle de versão e colaboração, utilizamos o **GitHub**, o que garante um fluxo de trabalho eficiente e seguro entre os membros da equipe de desenvolvimento.

<img src="../docs/img/tecnologias.jpg" alt="tecnologias"/>

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
