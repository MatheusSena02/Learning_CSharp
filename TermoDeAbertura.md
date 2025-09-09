# Termo de Abertura do Projeto (TAP)  
**Projeto:** VetControl � Sistema de Gest�o de Cl�nica Veterin�ria  
**Solicitante:** Teteu  
**Patrocinador:** Autoestudo / Curso C# Essencial (Udemy)  
**Data de In�cio:** 2025-09-09  
**Vers�o:** 1.0  

---

## Objetivo
Desenvolver um sistema em **C#** para gerenciamento de uma cl�nica veterin�ria, cobrindo desde cadastros at� faturamento, com foco em aplicar todos os conceitos do curso **C# Essencial (B�nus LINQ)**.

---

## Escopo
**Inclui:**
- Cadastro de tutores, pacientes, veterin�rios, produtos, servi�os.  
- Controle de agendamentos e atendimentos (consulta, vacina, exame).  
- Gest�o de estoque e faturamento com c�lculos ass�ncronos de imposto.  
- Persist�ncia em arquivos JSON e exporta��o/importa��o via CSV.  
- Relat�rios via LINQ e alertas por eventos/delegates.  
- Backup ass�ncrono de dados e logs de opera��o.  

**N�o Inclui (fora de escopo):**
- Interface gr�fica (GUI).  
- Banco de dados relacional (uso exclusivo de arquivos).  
- Integra��o real com servi�os externos (apenas simula��o com `Task.Delay`).  

---

## Justificativa
O projeto serve como **laborat�rio pr�tico** para consolidar os conhecimentos adquiridos no curso de C#, praticando POO, cole��es, LINQ, exce��es, eventos, arquivos e programa��o ass�ncrona em um contexto realista.

---

## Entreg�veis
- Aplica��o CLI funcional.  
- Relat�rios export�veis em CSV.  
- Arquivos JSON com dados persistentes.  
- Logs e backups autom�ticos.  

---

## Marcos Principais (Etapas)
1. Setup da solu��o e reposit�rios gen�ricos.  
2. Cadastro de entidades base (Tutor, Paciente, Vet, Produto, Servi�o).  
3. Agenda e valida��o de conflitos.  
4. Atendimentos e integra��o com estoque.  
5. Faturamento com c�lculo ass�ncrono de impostos.  
6. Eventos e notifica��es.  
7. Relat�rios via LINQ.  
8. Backup/restore ass�ncrono.  
9. Polimento final, testes e entrega.  

---

## Premissas
- O desenvolvimento ser� feito em ambiente local com .NET SDK.  
- Persist�ncia restrita a arquivos JSON/CSV.  
- Logs gravados em diret�rio local.  

---

## Restri��es
- N�o usar frameworks externos al�m do BCL.  
- Entregas sequenciais conforme etapas.  

---

## Crit�rios de Sucesso
- Sistema CLI cobre todas as funcionalidades listadas.  
- Relat�rios exportados corretamente.  
- Backup e cancelamento funcionando.  
- Erros tratados sem travar a aplica��o.  
