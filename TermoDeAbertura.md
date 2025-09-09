# Termo de Abertura do Projeto (TAP)  
**Projeto:** VetControl – Sistema de Gestão de Clínica Veterinária  
**Solicitante:** Teteu  
**Patrocinador:** Autoestudo / Curso C# Essencial (Udemy)  
**Data de Início:** 2025-09-09  
**Versão:** 1.0  

---

## Objetivo
Desenvolver um sistema em **C#** para gerenciamento de uma clínica veterinária, cobrindo desde cadastros até faturamento, com foco em aplicar todos os conceitos do curso **C# Essencial (Bônus LINQ)**.

---

## Escopo
**Inclui:**
- Cadastro de tutores, pacientes, veterinários, produtos, serviços.  
- Controle de agendamentos e atendimentos (consulta, vacina, exame).  
- Gestão de estoque e faturamento com cálculos assíncronos de imposto.  
- Persistência em arquivos JSON e exportação/importação via CSV.  
- Relatórios via LINQ e alertas por eventos/delegates.  
- Backup assíncrono de dados e logs de operação.  

**Não Inclui (fora de escopo):**
- Interface gráfica (GUI).  
- Banco de dados relacional (uso exclusivo de arquivos).  
- Integração real com serviços externos (apenas simulação com `Task.Delay`).  

---

## Justificativa
O projeto serve como **laboratório prático** para consolidar os conhecimentos adquiridos no curso de C#, praticando POO, coleções, LINQ, exceções, eventos, arquivos e programação assíncrona em um contexto realista.

---

## Entregáveis
- Aplicação CLI funcional.  
- Relatórios exportáveis em CSV.  
- Arquivos JSON com dados persistentes.  
- Logs e backups automáticos.  

---

## Marcos Principais (Etapas)
1. Setup da solução e repositórios genéricos.  
2. Cadastro de entidades base (Tutor, Paciente, Vet, Produto, Serviço).  
3. Agenda e validação de conflitos.  
4. Atendimentos e integração com estoque.  
5. Faturamento com cálculo assíncrono de impostos.  
6. Eventos e notificações.  
7. Relatórios via LINQ.  
8. Backup/restore assíncrono.  
9. Polimento final, testes e entrega.  

---

## Premissas
- O desenvolvimento será feito em ambiente local com .NET SDK.  
- Persistência restrita a arquivos JSON/CSV.  
- Logs gravados em diretório local.  

---

## Restrições
- Não usar frameworks externos além do BCL.  
- Entregas sequenciais conforme etapas.  

---

## Critérios de Sucesso
- Sistema CLI cobre todas as funcionalidades listadas.  
- Relatórios exportados corretamente.  
- Backup e cancelamento funcionando.  
- Erros tratados sem travar a aplicação.  
