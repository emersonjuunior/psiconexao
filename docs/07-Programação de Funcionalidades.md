# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Nesta seção, é essencial relacionar os requisitos atendidos com os artefatos criados (código fonte) e com o(s) responsável(is) pelo desenvolvimento de cada artefato a cada etapa. Nesta seção também deverão ser apresentadas, se necessário, as instruções para acesso e verificação da **implementação que deve estar funcional no ambiente de hospedagem obrigatoriamente a partir da Etapa 03**.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefatos produzidos | Aluno(a) responsável |
|------|-----------------------------------------|----|----|
|RF-001| O sistema deve permitir o cadastro de Psicólogos e pacientes incluindo dados como nome, e-mail, telefone e senha e outras informações essenciais para identificação e autenticação. | Controller `AuthController` e View `Auth`/`Cadastro` | Karina Nunes |
|RF-002| O sistema deve enviar um e-mail de confirmação após cadastro para garantir a autenticidade dos usuários. | Controller `AuthController` e View `Auth`/`CadastroEmAnalise` | Matheus Bacelar |
|RF-003| O sistema deve permitir que os usuários consigam logar na aplicação com e-mail e senha e em seguida ter acesso ao seu perfil e menu disponível correspondente a sua autenticação. | Controller `AuthController` e View `Auth`/`Login` | Karina Nunes |
|RF-004| O sistema deve permitir que os usuários recuperem sua senha por e-mail em casos de esquecimento ou outro pertinente. | Controller `AuthController`, View `Auth`/`EsqueceuSenha` e View `Auth`/`RedefinirSenha` | Karina Nunes |
|RF-005| O sistema deve permitir que o psicólogo edite seu perfil posteriormente ao cadastro, podendo atualizar informações como áreas de especialização, foto de perfil, descrição profissional, preço de consulta, disponibilidade de agenda e preencher um histórico de consulta dos pacientes atendidos. | Controller `PsicologoController` e View `Psicologo`/`Editar` | Karina Nunes |
|RF-006| O sistema deve permitir que o paciente edite seu perfil posteriormente ao cadastro, podendo atualizar informações relevantes ao seu perfil. | Controller `PacientesController` e View `Pacientes`/`Edit` | Matheus Bacelar |
|RF-007| O sistema deve permitir ao paciente enviar solicitação de agendamento de acordo com a disponibilidade do profissional. | Controller `ConsultasController` e View `Consultas`/`Create` | Patrick Breno, Safira Garcia e Vanessa André |
|RF-008| O sistema de permitir que o psicólogo tenha acesso a uma lista pendente de consultas que estarão pendentes de avaliação por ele e que poderão ser classificadas em agendar, cancelar ou concluir. Bem como visualizar, de preferência na mesma tela, consultas confirmadas. | Controller `DisponibilidadesController`, View `Psicologo`/`Perfil`  | Emerson Junior e Nayana Loivos |
|RF-009| O sistema deve permitir que o paciente visualize a agenda com dias e horários disponíveis do profissional desejado e solicite a consultada que ficará pendente até a confirmação ou cancelamento. | Controller `DisponibilidadeController`, View `Disponibilidades`/`Create`, View `Disponibilidades`/`Edit` | Emerson Junior e Nayana Loivos |
|RF-0010| O sistema deve enviar e-mail de confirmação/cancelamento ao paciente que possui uma consulta pendente. | Controller `ConsultasController` | Matheus Bacelar |
|RF-0011| O sistema deve permitir que o paciente realize buscas na aplicação contando com filtros adicionais como especialidade, preço da consulta e horários e datas disponíveis. | Controller `PsicologoController` e View `Psicologo`/`Lista`| Patrick Breno, Safira Garcia e Vanessa André |
|RF-0012|  O sistema deve permitir que os psicólogos acessem e mantenham um histórico das consultas dos pacientes, incluindo anotações e progresso para um acompanhamento contínuo e personalização do atendimento. No entanto, devido à priorização de funcionalidades essenciais, o desenvolvimento desse requisito está planejado para fases futuras do projeto. | Controller `Pacientes`, View `Paciente`/`Edit` e `Paciente`/`Details` | Patrick Breno, Safira Garcia e Vanessa André |


# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
