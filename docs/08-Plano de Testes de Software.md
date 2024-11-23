# Plano de Testes de Software

# Introdução 
O objetivo deste plano de teste é garantir que o sistema funcione conforme os 
requisitos funcionais. 
# Estratégia de Teste 
A estratégia inclui a execução de testes funcionais, testes de integração e testes de 
usabilidade para verificar se o sistema atende às expectativas dos usuários. 
# Tipos de Teste 
**Teste Funcional:** 
Para verificar o funcionamento de cada requisito. 
**Teste de Integração:** 
Para validar a integração com WhatsApp e outras 
funcionalidades externas. 
**Teste de Usabilidade:** 
Para garantir uma boa experiência de usuário. 
**Teste de Segurança:**
Para garantir que o sistema implemente corretamente a 
autenticação e autorização. 
# Plano de Testes Detalhado

| Caso de Teste               | CT-01: Cadastro de Psicólogo e Paciente       |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF01: O sistema deve permitir o cadastro de Psicólogos e pacientes incluindo dados como nome, e-mail, telefone e senha e outras informações essenciais para identificação e autenticação. |
| **Objetivos do Teste**      | Verificar se o sistema permite o cadastro de psicólogos e pacientes.       |
| **Passos**                  | 1. Acessar a página de cadastro. <br> 2. Preencher os campos obrigatórios (nome, e-mail, telefone, senha). <br> 3. Clicar em "Cadastre-se". |
| **Critérios de êxito**      | O cadastro é criado com sucesso e uma mensagem de confirmação é exibida.   |

---

| Caso de Teste               | CT-02: Envio de E-mail de Confirmação Após Cadastro            |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF02: O sistema deve enviar um e-mail de confirmação após cadastro para garantir a autenticidade dos usuários.      |
| **Objetivos do Teste**      | Verificar se o sistema envia um e-mail de confirmação após o cadastro.     |
| **Passos**                  | 1. Completar o cadastro conforme o CT-01. <br> 2. Verificar a caixa de entrada do e-mail informado no cadastro. |
| **Critérios de êxito**      | O e-mail de confirmação é recebido com sucesso.                            |

---

| Caso de Teste               | CT-03: Login com E-mail e Senha               |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF03: O sistema deve permitir que os usuários consigam logar na aplicação com e-mail e senha e em seguida ter acesso ao seu perfil e menu disponível correspondente a sua autenticação.          |
| **Objetivos do Teste**      | Verificar se o sistema permite o login com e-mail e senha válidos. |
| **Passos**                  | 1. Acessar a página de login. <br> 2. Inserir e-mail e senha válidos. <br> 3. Clicar em "Entrar". |
| **Critérios de êxito**      | O usuário é autenticado e redirecionado para o painel correto (paciente ou psicólogo). |

---

| Caso de Teste               | CT-04: Recuperação de Senha                   |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF04: O sistema deve permitir que os usuários recuperem sua senha por e-mail em casos de esquecimento ou outro pertinente.                      |
| **Objetivos do Teste**      | Verificar se o sistema permite a recuperação de senha.          |
| **Passos**                  | 1. Acessar a página de recuperação de senha. <br> 2. Inserir o e-mail cadastrado. <br> 3. Enviar a solicitação de recuperação. |
| **Critérios de êxito**      | Um e-mail de recuperação de senha é enviado ao usuário.                    |

---

| Caso de Teste               | CT-05: Edição de Perfil do Psicólogo                           |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF05: O sistema deve permitir que o psicólogo edite seu perfil posteriormente ao cadastro, podendo atualizar informações como áreas de especialização, foto de perfil, descrição profissional, preço de consulta, disponibilidade de agenda e preencher um histórico de consulta dos pacientes atendidos.            |
| **Objetivos do Teste**      | Verificar se o psicólogo pode editar seu perfil após o cadastro.              |
| **Passos**                  | 1. Acessar o perfil do psicólogo. <br> 2. Editar os campos (ex.: especialização, foto, preço, agenda, etc). <br> 3. Salvar as alterações. |
| **Critérios de êxito**      | As informações atualizadas são salvas com sucesso.                        |

---

| Caso de Teste               | CT-06: Edição de Perfil do Paciente                             |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF06: O sistema deve permitir que o psicólogo edite o perfil do paciente, podendo atualizar informações relevantes ao perfil.                             |
| **Objetivos do Teste**      | Verificar se o Psicólogo pode editar o perfil do Paciente.         |
| **Passos**                  | 1. Acessar o perfil do paciente. <br> 2. Editar as informações relevantes. <br> 3. Salvar as alterações. |
| **Critérios de êxito**      | As alterações são salvas corretamente.                        |

---

| Caso de Teste               | CT-07: Solicitação de Agendamento pelo Paciente                |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF07: O sistema deve permitir ao paciente enviar solicitação de agendamento de acordo com a disponibilidade do profissional.             |
| **Objetivos do Teste**      | Verificar se o paciente pode solicitar agendamento.  |
| **Passos**                  | 1. Acessar o perfil do psicólogo. <br> 2. Visualizar os horários disponíveis. <br> 3. Selecionar um horário e enviar a solicitação. |
| **Critérios de êxito**      | A consulta é marcada como pendente e o psicólogo recebe a notificação.    |

---

| Caso de Teste               | CT-08: Acesso a Lista de Consultas Pendentes pelo Psicólogo     |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF08: O sistema de permitir que o psicólogo tenha acesso a uma lista pendente de consultas que estarão pendentes de avaliação por ele e que poderão ser classificadas em agendar, cancelar ou concluir. Bem como visualizar, de preferência na mesma tela, consultas confirmadas.   |
| **Objetivos do Teste**      | Verificar se o psicólogo pode visualizar e gerenciar sua lista de consultas pendentes.  |
| **Passos**                  | 1. Acessar a lista de consultas pendentes. <br> 2. Conferir as consultas como "Agendado", "Cancelado" ou "Concluído".  |
| **Critérios de êxito**      | As consultas são gerenciadas corretamente.                                |

---

| Caso de Teste               | CT-09: Visualização de Agenda pelo Paciente       |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF09: O sistema deve permitir que o paciente visualize a agenda com dias e horários disponíveis do profissional desejado e solicite a consultada que ficará pendente até a confirmação ou cancelamento.              |
| **Objetivos do Teste**      | Verificar se o paciente pode visualizar a agenda do psicólogo. |
| **Passos**                  | 1. Acessar o perfil do psicólogo. <br> 2. Visualizar a agenda com os horários disponíveis. |
| **Critérios de êxito**      | O paciente visualiza os horários disponíveis corretamente.                 |

---

| Caso de Teste               | CT-10: Envio de E-mail de Confirmação/Cancelamento         |
| :-------------------------- | :------------------------------------------------------------------------- |
| **Requisitos Associados**   | RF10: O sistema deve enviar e-mail de confirmação/cancelamento ao paciente que possui uma consulta pendente.	 |
| **Objetivos do Teste**      | Verificar se o sistema envia e-mails de confirmação ou cancelamento de consultas.  |
| **Passos**                  | 1. O psicólogo confirma ou cancela a consulta. <br> 2. Verificar o e-mail do paciente. |
| **Critérios de êxito**      | O paciente recebe um e-mail com a confirmação ou cancelamento da consulta. |

---

| Caso de Teste               | CT-11: Busca com Filtros                        |
| :-------------------------- | :------------------------------------------------------------------------ |
| **Requisitos Associados**   | RF11: O sistema deve permitir que o paciente realize buscas na aplicação contando com filtros adicionais como especialidade, preço da consulta e horários e datas disponíveis.          |
| **Objetivos do Teste**      | Verificar se o paciente pode buscar psicólogos com filtros. |
| **Passos**                  | 1. Acessar a página de busca. <br> 2. Aplicar filtros (ex.: especialidade, preço, disponibilidade). |
| **Critérios de êxito**      | A busca retorna os resultados conforme os filtros aplicados.              |

---

| Caso de Teste               | CT-12: Histórico de Consultas para Psicólogos                 |
| :-------------------------- | :------------------------------------------------------------------------ |
| **Requisitos Associados**   | RF12: O sistema deve permitir que os psicólogos acessem e mantenham um histórico das consultas dos pacientes, incluindo anotações e progresso para um acompanhamento contínuo e personalização do atendimento. No entanto, devido à priorização de funcionalidades essenciais, o desenvolvimento desse requisito está planejado para fases futuras do projeto.    |
| **Objetivos do Teste**      | Verificar se o psicólogo pode manter um histórico de consultas dos pacientes. |
| **Passos**                  | 1. Acessar o histórico de consultas no painel do psicólogo. <br> 2. Adicionar anotações sobre o progresso do paciente. |
| **Critérios de êxito**      | O histórico é atualizado com sucesso.                                    |


 

# Ferramentas de Teste

**Ferramentas de Automação:** Selenium para testes de interface. 

**Ferramentas de Teste de Integração:** Postman para testar as APIs. 

**Ambiente de Teste:** Dispositivos mobile e navegadores web (Chrome, Firefox). 
