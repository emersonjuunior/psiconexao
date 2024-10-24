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

Requisitos Funcionais
Cadastro de Psicólogo e Paciente 
Requisito: RF01 
Objetivo: Verificar se o sistema permite o cadastro de psicólogos e pacientes. 
Pré-condições: O sistema deve estar disponível para novos cadastros. 
Passos: 
Acessar a página de cadastro. 
Preencher os campos obrigatórios (nome, e-mail, telefone, senha). 
Enviar o formulário de cadastro. 
Resultado Esperado: O cadastro é criado com sucesso e uma mensagem de confirmação é exibida. 

Envio de E-mail de Confirmação Após Cadastro 
Requisito: RF02 
Objetivo: Verificar se o sistema envia um e-mail de confirmação após o cadastro. 
Pré-condições: O cadastro deve ser realizado. 
Passos: 
Completar o cadastro (conforme Cenário 1). 
Verificar a caixa de entrada do e-mail informado no cadastro. 
Resultado Esperado: O e-mail de confirmação é recebido com sucesso. 

Login com E-mail e Senha 
Requisito: RF03 
Objetivo: Verificar se o sistema permite o login com e-mail e senha válidos. 
Pré-condições: O usuário deve estar cadastrado e com a conta confirmada. 
Passos: 
Acessar a página de login. 
Inserir e-mail e senha válidos. 
Clicar em "Entrar". 
Resultado Esperado: O usuário é autenticado e redirecionado para o painel correto (paciente ou psicólogo). 

Recuperação de Senha 
Requisito: RF04 
Objetivo: Verificar se o sistema permite a recuperação de senha. 
Pré-condições: O usuário deve estar cadastrado. 
Passos: 
Acessar a página de recuperação de senha. 
Inserir o e-mail cadastrado. 
Enviar a solicitação de recuperação. 
Resultado Esperado: Um e-mail de recuperação de senha é enviado ao usuário. 
Edição de Perfil do Psicólogo 

Requisito: RF05 
Objetivo: Verificar se o psicólogo pode editar seu perfil após o cadastro. 
Pré-condições: O psicólogo deve estar autenticado. 
Passos: 
Acessar o perfil do psicólogo. 
Editar os campos (especialização, foto, preço, agenda, etc.). 
Salvar as alterações. 
Resultado Esperado: As informações atualizadas são salvas com sucesso. 

Edição de Perfil do Paciente 
Requisito: RF06 
Objetivo: Verificar se o paciente pode editar seu perfil. 
Pré-condições: O paciente deve estar autenticado. 
Passos: 
Acessar o perfil do paciente. 
Editar as informações relevantes. 
Salvar as alterações. 
Resultado Esperado: As alterações são salvas corretamente. 

Solicitação de Agendamento pelo Paciente 
Requisito: RF07 
Objetivo: Verificar se o paciente pode solicitar agendamento. 
Pré-condições: O paciente deve estar autenticado e o psicólogo deve ter horários disponíveis. 
Passos: 
Acessar o perfil do psicólogo. 
Visualizar os horários disponíveis. 
Selecionar um horário e enviar a solicitação. 
Resultado Esperado: A consulta é marcada como pendente e o psicólogo recebe a notificação. 

Acesso a Lista de Consultas Pendentes pelo Psicólogo 
Requisito: RF08 
Objetivo: Verificar se o psicólogo pode visualizar e gerenciar sua lista de consultas pendentes. 
Pré-condições: O psicólogo deve estar autenticado e com consultas pendentes. 
Passos: 
Acessar a lista de consultas pendentes. 
Classificar as consultas como "Agendado", "Cancelado" ou "Concluído". 
Resultado Esperado: As consultas são gerenciadas corretamente. 

Visualização de Agenda pelo Paciente 
Requisito: RF09 
Objetivo: Verificar se o paciente pode visualizar a agenda do psicólogo. 
Pré-condições: O paciente deve estar autenticado. 
Passos: 
Acessar o perfil do psicólogo. 
Visualizar a agenda com os horários disponíveis. 
Resultado Esperado: O paciente visualiza os horários disponíveis corretamente. 

Envio de E-mail de Confirmação/Cancelamento 
Requisito: RF10 
Objetivo: Verificar se o sistema envia e-mails de confirmação ou cancelamento de consultas. 
Pré-condições: Uma consulta deve estar pendente ou ser confirmada. 
Passos: 
O psicólogo confirma ou cancela a consulta. 
Verificar o e-mail do paciente. 
Resultado Esperado: O paciente recebe um e-mail com a confirmação ou cancelamento da consulta. 

Busca com Filtros 
Requisito: RF11 
Objetivo: Verificar se o paciente pode buscar psicólogos com filtros. 
Pré-condições: Psicólogos devem estar cadastrados com informações preenchidas. 
Passos: 
Acessar a página de busca. 
Aplicar filtros (especialidade, preço, disponibilidade). 
Resultado Esperado: A busca retorna os resultados de acordo com os filtros aplicados. 

Histórico de Consultas para Psicólogos 
Requisito: RF12 
Objetivo: Verificar se o psicólogo pode manter um histórico de consultas dos pacientes. 
Pré-condições: Psicólogo autenticado e consultas registradas. 
Passos: 
Acessar o histórico de consultas no painel do psicólogo. 
Adicionar anotações sobre o progresso do paciente. 
Resultado Esperado: O histórico é atualizado com sucesso. 

# Ferramentas de Teste

**Ferramentas de Automação:** Selenium para testes de interface. 

**Ferramentas de Teste de Integração:** Postman para testar as APIs. 

**Ambiente de Teste:** Dispositivos mobile e navegadores web (Chrome, Firefox). 
