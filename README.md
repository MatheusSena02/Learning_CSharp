# VetControl 🐾

Sistema de Gestão de Clínica Veterinária desenvolvido em **C#** com foco em praticar os principais conceitos da linguagem: fundamentos, POO, coleções genéricas, LINQ, tratamento de exceções, eventos/delegates, arquivos/streams e programação assíncrona.

## 🚀 Objetivo do Projeto
Criar um sistema **robusto de linha de comando (CLI)** para gerenciar tutores, pacientes, veterinários, agenda, atendimentos, estoque e faturamento, com persistência em arquivos JSON/CSV, geração de relatórios via LINQ e processos assíncronos como backup.

---

## 📦 Funcionalidades
- **Cadastro e Consulta**: tutores, pacientes, veterinários, produtos (medicamentos/insumos), serviços.  
- **Agenda e Atendimentos**: criação de agendamentos, consultas, vacinas e exames com controle de conflitos de horário.  
- **Estoque e Faturamento**: movimentação de estoque, faturamento com impostos calculados de forma assíncrona.  
- **Relatórios (LINQ)**: top produtos, receita por período/veterinário, vacinas em atraso, status da agenda.  
- **Eventos e Delegates**: alerta de estoque baixo, lembrete de vacinas, notificações persistidas em JSON.  
- **Persistência em Arquivos**: JSON para entidades, CSV para importação/exportação, logs em `.log`.  
- **Assíncrono**: backup de dados com `CancellationToken` e cálculo de impostos sem travar o fluxo.  

---

## 🛠️ Estrutura do Projeto
- **VetControl.Domain** → Entidades, regras de negócio, interfaces.  
- **VetControl.Infra** → Persistência em arquivos, logs, import/export.  
- **VetControl.CLI** → Interface de linha de comando (menus e comandos).  

---

## ⌨️ Comandos CLI
- `tutor add|list|find|update|delete`  
- `paciente add|list|find|by-tutor`  
- `vet add|list`  
- `produto import-csv|add|list|low-stock`  
- `servico add|list`  
- `agenda new|list|by-vet|by-day|cancel|finish`  
- `atendimento consulta|vacina|exame`  
- `estoque entrada|saida`  
- `fatura abrir|add-item|fechar|listar`  
- `relatorio receita|top-produtos|vacinas-pendentes|agenda-status`  
- `sistema backup-start|backup-cancel|notificacoes`  

---

## 📑 Critérios de Aceite
- CRUD completo e persistência em arquivos.  
- Agenda sem conflitos e com status corretos.  
- Estoque integrado a atendimentos com exceções tratadas.  
- Eventos disparando alertas e gravando notificações.  
- Relatórios exportáveis em CSV.  
- Backup assíncrono com cancelamento funcional.  
- Logs de erros e operações.  

---

## 📚 Tecnologias
- **.NET / C#**
- **JSON / CSV / StreamWriter**
- **LINQ**
- **Tasks / Async Await**

---

## 🎯 Status
Em desenvolvimento. Cada etapa do projeto cobre os módulos do curso **C# Essencial (Udemy)**.
