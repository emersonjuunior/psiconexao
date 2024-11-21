# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| Caso de Teste         | CT-01: Verificar o funcionamento do cadastro de Psicólogo e Paciente      |
|:--------------------:	|:-----------------------------------------------------------------------:	|
|	Requisito Associado 	| RF-01: O sistema deve permitir o cadastro de Psicólogos e pacientes incluindo dados como nome, e-mail, telefone e senha e outras informações essenciais para identificação e autenticação. |
| Registro de evidência | Figura abaixo apresenta a tela de cadastro preenchida. <br> ![Captura de tela 2024-11-19 190141](https://github.com/user-attachments/assets/5c649075-9358-4f46-bbee-144fe006c179) |

| **Caso de Teste** 	| **CT-03: Login com E-mail e Senha** 	|
|:---:	|:---:	|
|	Requisito Associado 	|RF03: O sistema deve permitir que os usuários consigam logar na aplicação com e-mail e senha e em seguida ter acesso ao seu perfil e menu disponível correspondente a sua autenticação. |
| Registro de evidência | Figura 1: Tela de erro (E-mail ou senha inválidos) / Figura 2: Redirecionamento para a página após o login <br>	 <img src="https://github.com/user-attachments/assets/36b01327-4522-4b0e-be90-f4415843062b" width="45%" style="display: inline-block;"> <img src="https://github.com/user-attachments/assets/ca88439e-6bd4-453b-8a68-c923ffae50e1" width="45%" style="display: inline-block;"> |


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
