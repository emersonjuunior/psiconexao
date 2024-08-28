# Especificações do Projeto

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

## Personas

Persona 1
<img width="1849" alt="Persona 1" src="https://github.com/user-attachments/assets/6ba0056f-5ea6-4d1c-9738-c326f6d7b1dd">

Persona 2
<img width="1849" alt="Persona 2" src="https://github.com/user-attachments/assets/4c0cd953-b2b1-4345-b3be-8be8b92afd39">

Persona 3
<img width="1849" alt="Persona 3" src="https://github.com/user-attachments/assets/486f8cdc-2deb-4ffe-bbc1-460a9a764091">

Persona 4
<img width="1849" alt="Persona 4" src="https://github.com/user-attachments/assets/d0b9139f-1ef7-44a0-b696-b3760397747d">

Persona 5
<img width="1849" alt="Persona 5" src="https://github.com/user-attachments/assets/608429c8-8fec-4b2e-97ea-2147294deae9">


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:
<img width="2550" alt="Historias de usuário" src="https://github.com/user-attachments/assets/28b34baf-ded3-494a-9f5c-ea9b802dfce7">

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID     | Descrição do Requisito                                                                                                                                                                                                                         | Prioridade |
|--------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------|
| RF-001 | O sistema deve permitir que os usuários (profissionais) se cadastrem fornecendo nome, CPR, e-mail e senha com implementação de autenticação e autorização por e-mail.                                                                          | ALTA       | 
| RF-002 | O sistema deve permitir que os usuários (profissionais) criem e editem um perfil detalhado incluindo foto, uma breve biografia, WhatsApp de contato, vertente terapêutica, experiência, valores cobrados e se doa uma consulta social por mês. | ALTA       |
| RF-003 | O sistema deve permitir que os usuários (profissionais) façam login usando e-mail e senha.                                                                                                                                                     | ALTA       |
| RF-004 | O sistema deve possuir a função de recuperar senha do usuário cadastrado em caso de esquecimento.                                                                                                                                              | ALTA       |
| RF-005 | O sistema deve permitir que qualquer pessoa realize pesquisas por profissionais de psicologia e visualize o perfil escolhido.                                                                                                                  | ALTA       |
| RF-006 | O sistema deve permitir filtros nas pesquisas para que o potencial paciente consiga alcançar uma base maior de critérios como abordagem terapêutica, faixa de valores, temas de interesse, oferta de consulta social.                          | MÉDIA      |
| RF-007 | O sistema deve permitir que o potencial paciente envie mensagens diretamente para o profissional por meio da integração com o WhatsApp.                                                                                                        | MÉDIA      |
| RF-008 | O sistema deve permitir que o potencial paciente possa eleger a data disponível no calendário do profissional.                                                                                                                                 | MÉDIA      |
| RF-009 | O sistema deve permitir que o paciente receba confirmação por e-mail ao concordar com a data no calendário.                                                                                                                                    | MÉDIA      |
| RF-010 | O sistema deve enviar uma mensagem de notificação 2 horas antes de iniciar a sessão agendada.                                                                                                                                                  | MÉDIA      |
| RF-011 | O sistema deve permitir que o profissional escreva textos de sua autoria no Blog da aplicação auxiliando de forma assíncrona os leitores que buscam auxílio por meio de texto.                                                                 | MÉDIA      |
| RF-012 | O sistema deve permitir que profissionais possam efetuar pagamento opcional para destacar-se nos filtros de pesquisa da aplicação.                                                                                                             | BAIXA      |


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
