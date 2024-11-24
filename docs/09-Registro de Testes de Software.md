# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| Caso de Teste         | CT-01: Verificar o funcionamento do cadastro de Psicólogo e Paciente      |
|:--------------------:	|:-----------------------------------------------------------------------:	|
|	Requisito Associado 	| RF-01: O sistema deve permitir o cadastro de psicólogos e pacientes incluindo dados como nome, e-mail, telefone e senha e outras informações essenciais para identificação e autenticação. |
| Registro de evidência | Figura abaixo apresenta a tela de cadastro preenchida. <br> ![Captura de tela 2024-11-19 190141](https://github.com/user-attachments/assets/5c649075-9358-4f46-bbee-144fe006c179) |


| **Caso de Teste** 	| **CT-02: Envio de E-mail de Confirmação Após Cadastro** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF02: O sistema deve enviar um e-mail de confirmação após cadastro para garantir a autenticidade dos usuários. |
| Registro de evidência | Figura 1: Página redirecionada para "consultas" após o cadastro" <br> <img src="https://github.com/user-attachments/assets/f16c7e45-6e9a-4633-ae7d-cb4650595fec" style="display: inline-block;"> |



| **Caso de Teste** 	| **CT-03: Login com E-mail e Senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF03: O sistema deve permitir que os usuários consigam logar na aplicação com e-mail e senha e em seguida ter acesso ao seu perfil e menu disponível correspondente a sua autenticação. |
| Registro de evidência | Figura 1: Tela de erro (E-mail ou senha inválidos) / Figura 2: Redirecionamento para a página após o login. <br>	 <img src="https://github.com/user-attachments/assets/36b01327-4522-4b0e-be90-f4415843062b" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/ca88439e-6bd4-453b-8a68-c923ffae50e1" width="45%" style="display: inline-block;"> |

| **Caso de Teste** 	| **CT-04: Recuperação de Senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF04: O sistema deve permitir que os usuários recuperem sua senha por e-mail em casos de esquecimento ou outro pertinente. |
| Registro de evidência | Figura 1: Página para informar E-mail cadastrado / Figura 2: Pàgina para redefinição de senha <br>	 <img src="https://github.com/user-attachments/assets/29856758-ea08-41b7-bd52-dd44b23c109f" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/7cd5607e-b03b-44ba-8aaf-a9cf1984c422" width="45%" style="display: inline-block;"> |


| **Caso de Teste** 	| **CT-05: Edição de Perfil do Psicólogo** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF05: O sistema deve permitir que o psicólogo edite seu perfil posteriormente ao cadastro, podendo atualizar informações como áreas de especialização, foto de perfil, descrição profissional, preço de consulta, disponibilidade de agenda e preencher um histórico de consulta dos pacientes atendidos. |
| Registro de evidência | Figura 1: Mostra a página de edição de perfil com os dados já preenchidos. / Figura 2: Mostra o perfil com os dados atualizados e salvos. <br> <img src="https://github.com/user-attachments/assets/83904e54-51c7-4318-a567-ccd9b7fa6e5e" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/27631905-3e73-43ea-8394-8f698d057792" width="45%" style="display: inline-block;"> |

| **Caso de Teste** 	| **CT-06: Edição de Perfil do Paciente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF06: O sistema deve permitir que o psicólogo edite o perfil do paciente, podendo atualizar informações relevantes ao perfil. |
| Registro de evidência | Figura 1: Edição do perfil do paciente / Figura 2: Perfil do pacinte atualizado <br> <img src="https://github.com/user-attachments/assets/69942942-b884-481a-9ec4-e414d42373e8" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/0bb369eb-502f-4729-ac8a-cb0b8bd0492a" width="45%" style="display: inline-block;"> |


| **Caso de Teste** 	| **CT-07: Solicitação de Agendamento pelo Paciente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF07: O sistema deve permitir ao paciente enviar solicitação de agendamento de acordo com a disponibilidade do profissional.|
| Registro de evidência | Figura 1: Tela de agendamento preenchida pelo paciente  / Figura 2: Consulta exibida como pendente no perfil do psicólogo. <br> <img src="https://github.com/user-attachments/assets/bab6bdb2-fb4d-4cb0-bcd5-a4a79afb60a7" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/9c436d7c-68c3-4b41-8d1f-895101513a92" width="45%" style="display: inline-block;"> |


| **Caso de Teste** 	| **CT-08: Acesso a Lista de Consultas Pendentes pelo Psicólogo ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF08: O sistema de permitir que o psicólogo tenha acesso a uma lista pendente de consultas que estarão pendentes de avaliação por ele e que poderão ser classificadas em agendar, cancelar ou concluir. Bem como visualizar, de preferência na mesma tela, consultas confirmadas|
| Registro de evidência | Figura 1: Página para gerênciar consultas / Figura 2: Tela de confirmação para excluir uma consulta. <br> <img src="https://github.com/user-attachments/assets/2bf3cdf7-a5ae-43ed-98cc-9baf1e26b9cf" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/2b9918a2-804e-47a1-8351-346f15b08c57" width="45%" style="display: inline-block;"> |


| **Caso de Teste** 	| **CT-09: Visualização de Agenda pelo Paciente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF09: O sistema deve permitir que o paciente visualize a agenda com dias e horários disponíveis do profissional desejado e solicite a consultada que ficará pendente até a confirmação ou cancelamento.|
| Registro de evidência | Figura 1: Perfil do psicólogo exibindo as datas disponíveis na agenda / Figura 2: Tela para selecionar um horário disponível para o agendamento.<br> <img src="https://github.com/user-attachments/assets/b8ff81f8-8b1f-4ba0-93c7-546338157989" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/a6b7d03b-1372-40ac-a754-11c62ff38c5a" width="45%" style="display: inline-block;"> |

| **Caso de Teste** 	| **CT-10: Envio de E-mail de Confirmação/Cancelamento ** 	|
|:---:	|:---:	|
|	Requisito Associado 	|RF10: O sistema deve enviar e-mail de confirmação/cancelamento ao paciente que possui uma consulta pendente. |
| Registro de evidência | Figura 1: Paciente recebendo email confirmando sua consulta. <br> <img src="https://github.com/user-attachments/assets/d72ae7f4-1e99-4ce0-a892-932159937671" > |

| **Caso de Teste** 	| **CT-11: Busca com Filtros ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF11: O sistema deve permitir que o paciente realize buscas na aplicação contando com filtros adicionais como especialidade, preço da consulta e horários e datas disponíveis.|
| Registro de evidência | Figura 1: Selecionando filtros para encontrar psicólogos / Figura 2: psicólogos encontrados.<br> <img src="https://github.com/user-attachments/assets/1538f6f7-b3ac-4830-aa9f-a0d732fb493a" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/71c29e38-ef09-46cd-871c-4674261f1d8d" width="45%" style="display: inline-block;"> |

| **Caso de Teste** 	| **CT-12: Histórico de Consultas para Psicólogos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF12: O sistema deve permitir que os psicólogos acessem e mantenham um histórico das consultas dos pacientes, incluindo anotações e progresso para um acompanhamento contínuo e personalização do atendimento. No entanto, devido à priorização de funcionalidades essenciais, o desenvolvimento desse requisito está planejado para fases futuras do projeto. |
| Registro de evidência | Figura 1: Edição de histórico e traumas / Figura 2: Perfil do pacinte atualizado <br> <img src="https://github.com/user-attachments/assets/69942942-b884-481a-9ec4-e414d42373e8" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/0bb369eb-502f-4729-ac8a-cb0b8bd0492a" width="45%" style="display: inline-block;"> |

## Avaliação


###	CT-01: Verificar o funcionamento do cadastro de Psicólogo e Paciente: 
#### Pontos Fortes Identificados <br>
- O sistema conseguiu realizar o cadastro tanto de psicólogos quanto de pacientes, com os dados sendo armazenados corretamente no banco de dados.
- Redirecionamento após o cadastro, diferenciando entre psicólogos (para página de análise) e pacientes (para consultas). <br>

#### Pontos Fracos Identificados <br>
- Apesar de o cadastro ser realizado, não houve exibição de uma mensagem de confirmação para o usuário, o que pode gerar dúvidas sobre o sucesso da operação.
- Ausência de algumas verificações, como força de senha ou formatação de telefone. <br>

#### melhorias para as próximas iterações <br>
- Incluir uma mensagem de sucesso após o cadastro. Isso pode ser feito adicionando um alerta ou uma mensagem exibida na interface. <br>
- Incorporar validações mais robustas no back-end para senhas e formatos de dados. <br>
---
###	CT-02: Envio de E-mail de Confirmação Após Cadastro: 
#### Pontos Fracos Identificados <br>
- Após a conclusão do cadastro, o sistema não enviou o e-mail de confirmação para o endereço informado pelo usuário
- <br>

#### melhorias para as próximas iterações <br>
- Após o cadastro, gerar um token único e enviar um e-mail com um link para ativação da conta:<br>
---

### CT-03: Login com E-mail e Senha: 
#### Pontos Fortes Identificados <br>
- Autenticação Funcional: A validação de e-mail e senha foi eficaz, demonstrando que o mecanismo de autenticação atende ao requisito principal.
- Feedback para Credenciais Inválidas: O sistema exibiu corretamente uma mensagem de erro ao inserir dados inválidos, ajudando o usuário a identificar problemas.
- Redirecionamento Adequado: Após o login bem-sucedido, o sistema redirecionou os usuários para suas respectivas páginas (paciente ou psicólogo), de acordo com o perfil.<br>

#### Pontos Fracos Identificados <br>
- Mensagem Genérica para Erros: A mensagem exibida em caso de erro foi funcional, mas genérica ("E-mail ou senha inválidos"). Mensagens mais específicas poderiam ajudar, como indicar qual dos campos está errado.<br>

#### melhorias para as próximas iterações <br>
- Implementar mensagens mais específicas com base no problema detectado.<br>
---
### CT-04: Recuperação de Senha: 
#### Pontos Fortes Identificados <br>
- Ao clicar em "Esqueceu senha?", o sistema direciona para uma página onde o e-mail cadastrado é informado.
Após o envio, a página de redefinição de senha é exibida, permitindo que o usuário insira e confirme uma nova senha.
- Após a redefinição, o sistema redireciona o usuário para a página de login, sinalizando a conclusão do processo.<br>

#### Pontos Fracos Identificados <br>
- Sem o envio de e-mail ou código, qualquer pessoa com acesso ao e-mail cadastrado pode redefinir a senha sem validação adicional.<br>

#### melhorias para as próximas iterações <br>
- Enviar um e-mail ao usuário com um link seguro para redefinir a senha, contendo um token único.<br>
---



### CT-05: Edição de Perfil do Psicólogo : 
#### Pontos Fortes Identificados <br>
- Edição Funcional: Todas as informações editadas foram salvas com sucesso e exibidas corretamente no perfil.
- Interface Intuitiva: A página de edição permite o preenchimento claro de todos os campos relevantes para o perfil do psicólogo, com dados previamente preenchidos para facilitar alterações. <br>

#### Pontos Fracos Identificados <br>
- Falta de Confirmação Visual: Após salvar as alterações, não há uma mensagem explícita confirmando o sucesso da operação, o que pode gerar incerteza para o usuário.
- Validação Limitada no Front-end: A página de edição não apresenta validações visuais para os campos, como obrigatoriedade ou formato correto.<br>

#### melhorias para as próximas iterações <br>
- Adicionar Mensagens de Confirmação e Erro:
Após salvar, exibir uma mensagem como "Alterações salvas com sucesso!".
Em caso de erro, exibir uma notificação específica informando o problema.
- Validação no Front-end:
Incorporar validações em tempo real para os campos como formato de telefone, crp, preço da consulta.<br>
---
### CT-06: Edição de Perfil do Paciente: 
#### Pontos Fortes Identificados <br>
- O psicólogo consegue acessar o perfil do paciente e editar informações relevantes com sucesso.
- As informações editadas são salvas de forma eficaz no banco de dados, mantendo a integridade dos dados.<br>

#### Pontos Fracos Identificados <br>
- Não há um histórico ou registro das edições feitas no perfil do paciente, o que pode ser necessário para auditoria.
- Não há validações robustas nos campos editados, como formatos de telefone, e-mail ou dados pessoais.<br>

#### melhorias para as próximas iterações <br>
- Registrar as edições feitas no perfil do paciente, incluindo o campo alterado, o valor anterior e o novo valor, bem como a data e o responsável pela alteração.
- Adicionar validações nos campos editáveis, garantindo que informações como e-mail, CPF e telefone sigam formatos corretos.<br>
---


### CT-07: Solicitação de Agendamento pelo Paciente : 
#### Pontos Fortes Identificados <br>
- Solicitação Efetuada com Sucesso: O paciente conseguiu selecionar um horário disponível e enviar a solicitação de agendamento e a consulta foi registrada com o estado "Pendente" no sistema.
- Exibição no Perfil do Psicólogo: As consultas pendentes foram exibidas corretamente no perfil do psicólogo, permitindo sua gestão.<br>

#### Pontos Fracos Identificados <br>
- Falta de Notificação ao Psicólogo:
Apesar de a consulta ser exibida na lista de pendentes, nenhuma notificação foi enviada ao psicólogo para alertá-lo da nova solicitação.
- Erro na Identificação de Campos: Na interface de visualização das pendências do psicologo, acima do nome do paciente, o rótulo está incorreto, indicando "Psicólogo" em vez de "Paciente".<br>

#### melhorias para as próximas iterações <br>
- Adicionar Notificações ao Psicólogo: Implementar uma notificação via e-mail ou no sistema para informar ao psicólogo sobre a nova solicitação.
- Corrigir Rótulos na Interface: Revisar e corrigir a identificação de campos na Pendentes.cshtml visualizado pelo psicólogo, ajustando o rótulo para "Paciente" ao exibir o nome correspondente.<br>
---

### CT-08: Acesso a Lista de Consultas Pendentes pelo Psicólogo : 
#### Pontos Fortes Identificados <br>
- O psicólogo consegue acessar e gerenciar suas consultas pendentes, confirmadas ou concluídas.
- As ações de "Recusar" e "Confirmar" funcionam adequadamente, permitindo a classificação das consultas pendentes.
- Quando o psicólogo confirma uma consulta, o paciente recebe um e-mail automático com os detalhes da consulta confirmada.
- O sistema altera automaticamente o status das consultas para "Concluído" após a data e horário da consulta, otimizando o processo de gerenciamento.<br>

#### Pontos Fracos Identificados <br>
- A confirmação para exclusão depende de navegação para uma nova página, em vez de um modal pop-up que poderia melhorar a fluidez da interface.
- Não há filtros ou ordenação que facilitem a busca por consultas em listas extensas.<br>

#### melhorias para as próximas iterações <br>
- Substituir a navegação para página de exclusão por um modal pop-up para confirmar a ação diretamente.
- Adicionar a opção de filtro por status, data, e paciente, e permitir ordenação por ordem cronológica ou alfabética.<br>
---

### CT-09: Visualização de Agenda pelo Paciente : 
#### Pontos Fortes Identificados <br>
- O sistema permite que o paciente acesse o perfil do psicólogo e visualize as datas disponíveis em sua agenda, destacando horários livres.
- Após selecionar uma data, o sistema apresenta os horários disponíveis para agendamento, facilitando a escolha.
- Horários já selecionados para agendamento deixam de ser exibidos como disponíveis, evitando duplicidade de marcações.<br>

#### Pontos Fracos Identificados <br>
- Caso o psicólogo tenha muitas disponibilidades, não há uma funcionalidade explícita para filtrar horários por preferência ou intervalo de tempo.
- <br>

#### melhorias para as próximas iterações <br>
- Adicionar filtros que permitam aos pacientes buscar horários disponíveis por período (manhã, tarde, noite) ou intervalos de data.<br>
---

### CT-10: Envio de E-mail de Confirmação/Cancelamento : 
#### Pontos Fortes Identificados <br>
- Quando o psicólogo confirma uma consulta, o paciente recebe corretamente um e-mail contendo detalhes da consulta, como data e horário. <br>

#### Pontos Fracos Identificados <br>
- Quando o psicólogo recusa uma consulta, nenhum e-mail é enviado ao paciente, o que pode gerar dúvidas ou falta de comunicação sobre o status.<br>

#### melhorias para as próximas iterações <br>
- Implementar o envio de e-mails para informar o paciente quando uma consulta é recusada.<br>
---

### CT-11: Busca com Filtros: 
#### Pontos Fortes Identificados <br>
- Todos os filtros aplicados funcionaram corretamente, retornando os resultados esperados.
- A página de busca apresenta uma interface organizada, permitindo que o paciente selecione múltiplos filtros de forma clara e objetiva. <br>

#### Pontos Fracos Identificados <br>
- Não há sugestões automáticas de ajuste de filtros quando os resultados são escassos, o que poderia melhorar a experiência em casos de buscas restritivas.<br>

#### melhorias para as próximas iterações <br>
- Sugerir ao usuário filtros menos restritivos se houver poucos resultados encontrados, como ampliar a faixa de preço ou incluir mais especialidades.<br>
---

### CT-12: Histórico de Consultas para Psicólogos : 
#### Pontos Fortes Identificados <br>
- O psicólogo consegue acessar o perfil do paciente e editar informações relacionadas ao histórico de consultas e traumas.
- As alterações feitas no histórico são refletidas no perfil do paciente, permitindo acompanhamento contínuo e personalização do atendimento.<br>

#### Pontos Fracos Identificados <br>
- Não há um registro cronológico detalhado das consultas anteriores, o que limita o acompanhamento de longo prazo do paciente.
- As anotações sobre o progresso do paciente não são associadas a datas específicas ou consultas individuais.<br>

#### melhorias para as próximas iterações <br>
- Criar um modelo para armazenar anotações específicas de cada consulta, incluindo data e hora.
- Registrar mudanças no histórico, incluindo o responsável pela edição e a data da alteração.<br>
