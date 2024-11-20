# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| Caso de Teste         | CT-01: Verificar o funcionamento do cadastro de Psicólogo e Paciente      |
|:--------------------:	|:-----------------------------------------------------------------------:	|
|	Requisito Associado 	| RF-01: O sistema deve permitir o cadastro de Psicólogos e pacientes incluindo dados como nome, e-mail, telefone e senha e outras informações essenciais para identificação e autenticação. |
| Registro de evidência | A imagem abaixo apresenta a tela de cadastro preenchida. <br> ![Captura de tela 2024-11-19 190141](https://github.com/user-attachments/assets/5c649075-9358-4f46-bbee-144fe006c179) |

| **Caso de Teste** 	| **CT-02 – Realizar login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00Y - A aplicação deve permitir que um usuário previamente cadastrado faça login |
|Registro de evidência | www.teste.com.br/drive/ct-02 |

## Avaliação

### RF-01: 
#### Pontos Fortes Identificados <br>
- O sistema conseguiu realizar o cadastro tanto de psicólogos quanto de pacientes, com os dados sendo armazenados corretamente no banco de dados.
- Redirecionamento após o cadastro, diferenciando entre psicólogos (para página de análise) e pacientes (para consultas). <br>

#### Pontos Fracos Identificados <br>
- Apesar de o cadastro ser realizado, não houve exibição de uma mensagem de confirmação para o usuário, o que pode gerar dúvidas sobre o sucesso da operação.
- Ausência de algumas verificações, como força de senha ou formatação de telefone. <br>

#### melhorias para as próximas iterações <br>
- Incluir uma mensagem de sucesso após o cadastro. Isso pode ser feito adicionando um alerta ou uma mensagem exibida na interface. <br>
- Incorporar validações mais robustas no back-end para senhas e formatos de dados. <br>

### RF-02: 
#### Pontos Fortes Identificados <br>
- 
- <br>

#### Pontos Fracos Identificados <br>
- 
-  <br>

#### melhorias para as próximas iterações <br>
- 
- <br>

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
