# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Identifique, em torno de, 5 personas. Para cada persona, lembre-se de descrever suas angústicas, frustrações e expectativas de vida relacionadas ao problema. Além disso, defina uma "aparência" para a persona. Para isso, você poderá utilizar sites como [https://this-person-does-not-exist.com/pt#google_vignette](https://this-person-does-not-exist.com/pt) ou https://thispersondoesnotexist.com/ 

Utilize também como referência o exemplo abaixo:

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/IntApplicationProject-Template/blob/main/docs/img/AnaClara1.png" alt="Persona1"/>

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> 
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ana Clara  | Uma forma de identificar se uma agência é realmente confiável           | Me sentir mais segura ao contratar seus serviços               |
|Ana Clara       | Ter um mecanismo eficiente e rápido de comunicação                 | Que eu possa sanar todas as minhas dúvidas rapidamente |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito                                                                                                                                                                                                                        | Prioridade |
|--------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RF-001 | O sistema deve permitir que os usuários (profissionais) se cadastrem fornecendo nome, CPR, e-mail e senha com implementação de autenticação e autorização por e-mail.                                                                         | ALTA       | 
| RF-002 | O sistema deve permitir que os usuários (profissionais) criem e editem um perfil detalhado incluindo foto, uma breve biografia, WhatsApp de contato, vertente terapêutica, experiência, valores cobrados e se doa uma consulta social por mês. | ALTA       |
| RF-003 | O sistema deve permitir que os usuários (profissionais) façam login usando e-mail e senha.                                                                                                                                                    | ALTA       |
| RF-004 | O sistema deve possuir a função de recuperar senha do usuário cadastrado em caso de esquecimento.                                                                                                                                             | ALTA       |
| RF-005 | O sistema deve permitir que qualquer pessoa realize pesquisas por profissionais de psicologia e visualize o perfil escolhido.                                                                                                                 | ALTA       |
| RF-006 | O sistema deve permitir filtros nas pesquisas para que o potencial paciente consiga alcançar uma base maior de critérios como abordagem terapêutica, faixa de valores, temas de interesse, oferta de consulta social.                         | MÉDIA      |
| RF-007 | O sistema deve permitir que o potencial paciente envie mensagens diretamente para o profissional por meio da integração com o WhatsApp.                                                                                                       | MÉDIA      |
| RF-008 | O sistema deve permitir que o potencial paciente possa eleger a data disponível no calendário do profissional.                                                                                                                                | MÉDIA      |
| RF-009 | O sistema deve permitir que o paciente receba confirmação por e-mail ao concordar com a data no calendário e repetir a notificação 2 horas antes de iniciar a sessão.                                                                         | MÉDIA      |
| RF-010 | O sistema deve permitir que o profissional escreva textos de sua autoria no Blog da aplicação auxiliando de forma assíncrona os leitores que buscam auxílio por meio de texto.                                                                | MÉDIA      |
| RF-011 | O sistema deve permitir que profissionais possam efetuar pagamento opcional para destacar-se nos filtros de pesquisa da aplicação.                                                                                                            | BAIXA      |
| RF-012 | Em aberto.                                                                                                                                                                                                                                    | BAIXA      |


### Requisitos não Funcionais

| ID      | Descrição do Requisito                                                                                                                                  | Prioridade |
|---------|---------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RNF-001 | O sistema deve funcionar em plataformas web e mobile.                                                                                                   | ALTA       | 
| RNF-002 | As informações de perfil profissional devem estar disponíveis para todos os interessados e potenciais interessados no serviço oferecido pela aplicação. | ALTA       | 
| RNF-003 | O sistema deve fornecer um texto que aos potenciais pacientes devem concordar antes de marcar uma consulta com o profissional.                          | ALTA       |
| RNF-004 | O sistema deve descrever os termos de política e privacidade da aplicação.                                                                              | MÉDIA      |
| RNF-005 | O sistema deve apresentar acessibilidade.                                                                                                               | MÉDIA      |
| RNF-006 | O sistema deve permitir as dúvidas mais frequentes relacionadas às consultas com os profissionais.                                                      | BAIXA      |
| RNF-007 | O sistema deve retornar <=10 por página de pesquisa.                                                                                                    | BAIXA      |

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                                                                                                                                            |
|--|----------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre.                                                                                                               |
|02| O backend do sistema deve ser implementado na linguagem C# (.net) e o frontend do sistema deve ser processado no padrão dos navegadores web (Javascript, HTML, CSS). |

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

<img src="../docs/img/UseCaseDiagram.png" alt="Diagrama de Casos de Uso"/>

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
