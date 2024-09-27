# Plano de Testes de Software

# Introdução 
O objetivo deste plano de teste é garantir que o sistema funcione conforme os 
requisitos funcionais. 
# Estratégia de Teste 
A estratégia inclui a execução de testes funcionais, testes de integração e testes de 
usabilidade para verificar se o sistema atende às expectativas dos usuários. 
# Tipos de Teste 
Teste Funcional: 
Para verificar o funcionamento de cada requisito. 
Teste de Integração: 
Para validar a integração com WhatsApp e outras 
funcionalidades externas. 
Teste de Usabilidade: 
Para garantir uma boa experiência de usuário. 
Teste de Segurança:
Para garantir que o sistema implemente corretamente a 
autenticação e autorização. 
# Plano de Testes Detalhado

Requisitos Funcionais

RF-001: Cadastro de U suários (Profissionais) 

Objetivo: Verificar se o sistema permite o cadastro de usuários com nome, CPR, e-mail 
e senha, e se realiza a autenticação via e-mail. 
Situação de teste: Usuário tenta se cadastrar com todos os campos válidos. 
Teste: Preencher nome, CPR, e-mail e senha corretamente. 
Resultado Esperado: Usuário cadastrado com sucesso e e-mail de confirmação 
enviado. 
Situação de teste: Usuário tenta se cadastrar com e-mail inválido.
Teste: Inserir um e-mail no formato incorreto.
Resultado Esperado: Exibição de uma mensagem de erro informando que o e-mail é 
inválido.
Situação de teste: Tentativa de cadastro com senha muito curta. 
Teste: Inserir uma senha com menos de 8 caracteres.
Resultado Esperado: Mensagem de erro indicando o comprimento mínimo da senha. 

RF-002: Criação e Edição de Perfil de Usuário 
Objetivo: Verificar se o usuário pode criar e editar seu perfil detalhado. 
Situação de teste: Usuário cria perfil completo com foto, biografia, WhatsApp e outros 
dados. 
Teste: Preencher todos os campos e salvar o perfil. 
Resultado Esperado: Perfil criado com sucesso. 
Situação de teste: Usuário edita o perfil e altera a foto e a biografia. 
Teste: Alterar os campos e salvar novamente. 
Resultado Esperado: Alterações salvas corretamente. 
RF-003: Login de Usuário 
Objetivo: Garantir que os usuários consigam fazer login com e-mail e senha. 
Situação de teste: Login com credenciais corretas. 
Teste: Inserir e-mail e senha corretos. 
Resultado Esperado: Usuário autenticado com sucesso. 
Situação de teste: Tentativa de login com senha incorreta. 
Teste: Inserir e-mail correto e senha incorreta. 
Resultado Esperado: Mensagem de erro informando falha de autenticação. 
RF-004: Recuperação de Senha 
Objetivo: Testar a função de recuperação de senha. 
Situação de teste: Usuário solicita recuperação de senha com e-mail válido. 
Teste: Inserir e-mail cadastrado e solicitar redefinição de senha. 
Resultado Esperado: E-mail de redefinição enviado. 
Situação de teste: Tentativa de recuperação com e-mail não cadastrado. 
Teste: Inserir um e-mail que não está registrado. 
Resultado Esperado: Mensagem informando que o e-mail não está cadastrado. 
RF-005: Pesquisa por Profissionais 
Objetivo: Verificar se o sistema permite a busca por profissionais de psicologia. 
Situação de teste: Pesquisa por profissionais sem filtro. 
Teste: Realizar pesquisa simples sem aplicar filtros. 
Resultado Esperado: Lista de profissionais exibida. 
Situação de teste: Pesquisa com filtros aplicados (ex: abordagem terapêutica). 
Teste: Aplicar um filtro específico e pesquisar. 
Resultado Esperado: Lista de profissionais filtrada de acordo com os critérios. 
RF-006: Aplicação de Filtros na Pesquisa 
Objetivo: Verificar se os filtros funcionam corretamente. 
Situação de teste: Aplicar filtros como faixa de valores e temas de interesse. 
Teste: Selecionar valores e temas específicos e realizar a pesquisa. 
Resultado Esperado: Resultados retornados conforme os filtros aplicados. 
RF-007: Envio de Mensagens via WhatsApp 
Objetivo: Verificar a integração com o WhatsApp. 
Situação de teste: Usuário envia mensagem diretamente para o profissional. 
Teste: Clicar no botão de enviar mensagem via WhatsApp. 
Resultado Esperado: WhatsApp aberto com o número do profissional preenchido. 
RF-008: Agendamento de Datas no Calendário 
Objetivo: Verificar se o paciente pode selecionar uma data no calendário do 
profissional. 
Situação de teste: Paciente seleciona uma data disponível. 
Teste: Escolher uma data e confirmar o agendamento. 
Resultado Esperado: Data confirmada com sucesso. 
RF-009: Confirmação de Data por E-mail 
Objetivo: Garantir que o paciente receba a confirmação do agendamento por e-mail. 
Situação de teste: Paciente agenda uma consulta e recebe e-mail de confirmação. 
Teste: Verificar caixa de entrada após o agendamento. 
Resultado Esperado: E-mail de confirmação recebido com os detalhes da consulta. 
RF-010: Notificação 2 Horas Antes da Sessão 
Objetivo: Verificar se o sistema envia a notificação antes da sessão. 
Situação de teste: Envio automático de notificação duas horas antes da sessão. 
Teste: Simular uma sessão agendada e verificar o recebimento da notificação. 
Resultado Esperado: Notificação recebida a tempo. 
RF-011: Escrita de Textos no Blog 
Objetivo: Verificar se os profissionais podem escrever e publicar textos no blog. 
Situação de teste: Publicação de um texto no blog. 
Teste: Escrever um texto e publicá-lo. 
Resultado Esperado: Texto publicado corretamente. 
RF-012: Destaque com Pagamento 
Objetivo: Testar a funcionalidade de pagamento para destacar-se nos filtros de 
pesquisa. 
Situação de teste: Profissional realiza pagamento para destaque. 
Teste: Realizar o pagamento e verificar se o perfil aparece em destaque nos filtros. 
Resultado Esperado: Perfil destacado conforme o pagamento realizado. 
Ferramentas de Teste 
Ferramentas de Automação: Selenium para testes de interface. 
Ferramentas de Teste de Integração: Postman para testar as APIs. 
Ambiente de Teste: Dispositivos mobile e navegadores web (Chrome, Firefox). 
