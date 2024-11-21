# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| Caso de Teste         | CT-01: Verificar o funcionamento do cadastro de Psicólogo e Paciente      |
|:--------------------:	|:-----------------------------------------------------------------------:	|
|	Requisito Associado 	| RF-01: O sistema deve permitir o cadastro de Psicólogos e pacientes incluindo dados como nome, e-mail, telefone e senha e outras informações essenciais para identificação e autenticação. |
| Registro de evidência | Figura abaixo apresenta a tela de cadastro preenchida. <br> ![Captura de tela 2024-11-19 190141](https://github.com/user-attachments/assets/5c649075-9358-4f46-bbee-144fe006c179) |


| **Caso de Teste** 	| **CT-03: Login com E-mail e Senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF03: O sistema deve permitir que os usuários consigam logar na aplicação com e-mail e senha e em seguida ter acesso ao seu perfil e menu disponível correspondente a sua autenticação. |
| Registro de evidência | Figura 1: Tela de erro (E-mail ou senha inválidos) / Figura 2: Redirecionamento para a página após o login. <br>	 <img src="https://github.com/user-attachments/assets/36b01327-4522-4b0e-be90-f4415843062b" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/ca88439e-6bd4-453b-8a68-c923ffae50e1" width="45%" style="display: inline-block;"> |


| **Caso de Teste** 	| **CT-05: Edição de Perfil do Psicólogo** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF05: O sistema deve permitir que o psicólogo edite seu perfil posteriormente ao cadastro, podendo atualizar informações como áreas de especialização, foto de perfil, descrição profissional, preço de consulta, disponibilidade de agenda e preencher um histórico de consulta dos pacientes atendidos. |
| Registro de evidência | Figura 1: Mostra a página de edição de perfil com os dados já preenchidos. / Figura 2: Mostra o perfil com os dados atualizados e salvos. <br> <img src="https://github.com/user-attachments/assets/83904e54-51c7-4318-a567-ccd9b7fa6e5e" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/27631905-3e73-43ea-8394-8f698d057792" width="45%" style="display: inline-block;"> |


| **Caso de Teste** 	| **CT-07: Solicitação de Agendamento pelo Paciente** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF07: O sistema deve permitir ao paciente enviar solicitação de agendamento de acordo com a disponibilidade do profissional.|
| Registro de evidência | Figura 1: Tela de agendamento preenchida pelo paciente  / Figura 2: Consulta exibida como pendente no perfil do psicólogo. <br> <img src="https://github.com/user-attachments/assets/bab6bdb2-fb4d-4cb0-bcd5-a4a79afb60a7" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/9c436d7c-68c3-4b41-8d1f-895101513a92" width="45%" style="display: inline-block;"> |



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

### CT-07: Solicitação de Agendamento pelo Paciente : 
#### Pontos Fortes Identificados <br>
- Solicitação Efetuada com Sucesso: O paciente conseguiu selecionar um horário disponível e enviar a solicitação de agendamento e a consulta foi registrada com o estado "Pendente" no sistema.
- Exibição no Perfil do Psicólogo: As consultas pendentes foram exibidas corretamente no perfil do psicólogo, permitindo sua gestão.
 <br>

#### Pontos Fracos Identificados <br>
- Falta de Notificação ao Psicólogo:
Apesar de a consulta ser exibida na lista de pendentes, nenhuma notificação foi enviada ao psicólogo para alertá-lo da nova solicitação.
- Erro na Identificação de Campos: Na interface de visualização das pendências do psicologo, acima do nome do paciente, o rótulo está incorreto, indicando "Psicólogo" em vez de "Paciente".<br>

#### melhorias para as próximas iterações <br>
- Adicionar Notificações ao Psicólogo: Implementar uma notificação via e-mail ou no sistema para informar ao psicólogo sobre a nova solicitação.
- Corrigir Rótulos na Interface: Revisar e corrigir a identificação de campos na Pendentes.cshtml visualizado pelo psicólogo, ajustando o rótulo para "Paciente" ao exibir o nome correspondente.<br>
---
