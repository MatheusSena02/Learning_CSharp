# Git - Version Control 

<br>

## Conceito

O Git � um **sistema de controle de vers�o distribu�do (VSC)** e de c�digo aberto, criado por Linus Torvalds em 2005. Diferente de sistemas mais antigos como o SVN, onde o hist�rico de altera��es � centralizado, o Git permite que cada desenvolvedor tenha uma c�pia completa do hist�rico do reposit�rio em sua m�quina local.

Essa abordagem distribu�da torna opera��es di�rias como `commit`, `blame`, `diff`, `merge` e `log`  muito mais r�pidas, j� que n�o dependem de uma conex�o constante com um servidor central.

O Git tamb�m se destaca pelo seu poderoso suporte a ramifica��o (branching), mesclagem (merging) e pela capacidade de reescrever o hist�rico de um reposit�rio. Isso possibilitou o surgimento de fluxos de trabalho colaborativos eficientes, como o uso de pull requests. As pull requests s�o uma ferramenta popular que permite que equipes trabalhem em ramifica��es isoladas e revisem o c�digo umas das outras antes de mesclar as altera��es para o projeto principal.

## Prefixos Comuns para Commits no Git

- **feat:** Adi��o de uma nova funcionalidade  
  *Exemplo:* `feat: adicionar endpoint de login`

- **fix:** Corre��o de um bug  
  *Exemplo:* `fix: corrigir erro de valida��o no formul�rio`

- **docs:** Altera��es apenas na documenta��o  
  *Exemplo:* `docs: atualizar README com instru��es de instala��o`

- **style:** Mudan�as que n�o afetam o funcionamento do c�digo (espa�os, formata��o, v�rgulas)  
  *Exemplo:* `style: ajustar indenta��o do c�digo`

- **refactor:** Altera��es no c�digo que n�o mudam a funcionalidade, mas melhoram a estrutura  
  *Exemplo:* `refactor: otimizar fun��o de c�lculo`

- **perf:** Altera��es para melhorar desempenho  
  *Exemplo:* `perf: reduzir tempo de carregamento da p�gina inicial`

- **test:** Adi��o ou modifica��o de testes  
  *Exemplo:* `test: criar testes unit�rios para servi�o de autentica��o`

- **chore:** Altera��es em tarefas de build, depend�ncias ou configura��es  
  *Exemplo:* `chore: atualizar depend�ncias do projeto`

- **build:** Altera��es que afetam o sistema de build ou depend�ncias externas  
  *Exemplo:* `build: configurar webpack para produ��o`

- **ci:** Altera��es em arquivos de configura��o de integra��o cont�nua  
  *Exemplo:* `ci: adicionar pipeline no GitHub Actions`

- **revert:** Reverter um commit anterior  
  *Exemplo:* `revert: voltar altera��o que causou erro em produ��o`

- **hotfix:** Corre��o r�pida de problema cr�tico em produ��o  
  *Exemplo:* `hotfix: corrigir falha de autentica��o em produ��o`

## Cheatsheet do git

### Instala��o e Configura��o
```git
# Initialize a new Git repository
git init

# Clone and create a local copy of a remote repository
git clone <url>

# Configure global Git settings
git config --global <setting_name> <value>

# Configure local Git settings for a specific repo
git config --local <setting_name> <value>

# Show a summary of your Git configuration settings
git config --list

# Set a custom text editor for Git messages
git config --global core.editor "<editor_command>"

# Create a Git command alias
git config --global alias.<shortcut> <command>

# Enable automatic colorization of Git output
git config --global color.ui auto

# Cache Git credentials for a certain amount of time
git config --global credential.helper 'cache --timeout=<seconds>'

# Configure git to detect specific types of whitespace errors
git config --global core.whitespace <options>

# Automatically prune remote-tracking branches when fetching updates
git config --global fetch.prune true

# Set a custom diff tool for Git
git config --global diff.tool <tool>

# Set a custom merge tool for Git
git config --global merge.tool <tool>

# Compare changes using a custom diff tool
git difftool

# Resolve merge conflicts with a custom merge tool
git mergetool
```

### Opera��es de Arquivo

```git
# Show working tree status
git status

# Add files to the staging area
git add <file(s)>

# Add all modified files to the staging area
git add . 

# Remove files from working tree and staging area
git rm <file(s)>

# Move or rename a file
git mv <old_file> <new_file>

# Commit changes with a message
git commit -m "commit message"

# Show differences between working tree and last commit
git diff

# Assume a tracked file is unchanged
git update-index --assume-unchanged <file>

# Restore normal behavior of tracking changes
git update-index --no-assume-unchanged <file>

# Show differences between two commits
git diff <commit_id1>..<commit_id2>

# Unstage a file, but keep in the working directory
git rm --cached <file_name>
```

### Ramifica��o e Mesclagem

```git
# List all branches
git branch

# Create a new branch
git branch <branch_name>

# Switch to a specific branch
git checkout <branch_name>

# Merge a branch into the current branch
git merge <branch_name>

# Delete a specific branch
git branch -d <branch_name>

# List all remote branches
git branch -r

# List branches with additional information
git branch -vv

# Create a new branch based on a remote branch
git checkout -b <branch_name> <remote_name>/<remote_branch>

# Cancel merge in case of conflicts
git merge --abort

# Rebase the current branch onto another branch
git rebase <branch_name>

# Cancel an ongoing rebase operation
git rebase --abort

# Interactive rebase for edit, squash, re-order or drop commits
git rebase -i

# Rebase commits in the current branch onto a remote branch interactively
git rebase -i <remote_name>/<remote_branch>
```

### Reposit�rios Remotos

```git
# List remote repositories
git remote

# Add a remote repository
git remote add <name> <url>

# Fetch from a remote repository
git fetch <remote_name>

# Pull changes from a remote branch
git pull <remote_name> <remote_branch>

# Push changes to a remote repository
git push <remote_name> <local_branch>

# Remove a remote repository
git remote rm <remote_name>

# Display information about a specific remote repository
git remote show <remote_name>

# Show the tracking branches for remote repositories
git remote show <remote_name> --verbose

# Fetch updates from all remote repositories
git remote update

# Force-push changes to a remote repository, overwriting remote history
git push --force <remote_name> <local_branch>

# Push all tags to a remote repository
git push --tags <remote_name>

# Rename a remote repository
git remote rename <old_name> <new_name>

# Change the URL of a remote repository
git remote set-url <name> <new_url>

# Remove stale remote-tracking branches
git remote prune <remote_name>

# List all remote branches that have been merged into the current branch
git branch -r --merged

# List all remote branches not yet merged into the current branch
git branch -r --no-merged

# Fetch updates from a remote repository and prune obsolete remote-tracking branches
git fetch -p

# Track a remote branch and set up the local branch to automatically sync with it
git branch --track <branch_name> <remote_name>/<remote_branch>

# Set an existing local branch to track a remote branch
git branch -u <remote_name>/<remote_branch>

# Push a branch to a remote repository and set it to track the remote branch
git push -u <remote_name> <local_branch>

# Remove the tracking association between a local and a remote branch
git branch --unset-upstream <branch_name>
```

### Hist�rico de Commits

```git
# Show commit history
git log

# Display a condensed commit history
git log --oneline

# Show branching commit history
git log --graph

# Filter commit history by author
git log --author=<author_name>

# Show commit history since specific date
git log --since=<date>

# Show commit history until specific date
git log --until=<date>
```

### Etiquetas ou Tags

```git
# List all tags
git tag

# Create a new tag at a specific commit
git tag <tag_name> <commit_id>

# Create an annotated tag with a message
git tag -a <tag_name> -m "tag message"

# Delete a specific tag
git tag -d <tag_name>

# Delete a specific remote tag
git push <remote_name> --delete <tag_name>

# Show information about a specific tag
git show <tag_name>
```

### Esconderijos ou Stash 

```git
# Temporarily save changes in the working tree
git stash save "stash message"

# List all stashes
git stash list

# Apply changes from a specific stash
git stash apply <stash>

# Remove a specific stash
git stash drop <stash>

# Remove all stashes
git stash clear
```

### Sele��o seletiva

```git
# Apply a specific commit from one branch to another
git cherry-pick <commit_id>
```

### Gerenciamento de Commits

```git
# Modify the latest commit
git commit --amend

# Create a new commit that undoes changes from a previous commit
git revert <commit_id>

# Discard changes and move HEAD to a specific commit
git reset --hard <commit_id>

# Move HEAD to a specific commit, but preserve staged changes
git reset --soft <commit_id>

# Show a record of all changes made to the local repository head
git reflog
```

### Subm�dulos, sub�rvores e subm�dulos avan�ados

```git
# Add a submodule to the current repository
git submodule add <repository_url> <path>

# Initialize and update all submodules recursively
git submodule update --init --recursive

# Add a subtree to the current repository
git subtree add --prefix=<path> <repository_url>

# Initialize the submodules in the repository
git submodule init

# Update the submodules to their latest commits
git submodule update
# Execute a specific command in each submodule
git submodule foreach <command>

# Unregister a submodule
git submodule deinit <path>
```

### Ganchos e automa��o, e ferramentas de compara��o e mesclagem

```git 
# Locate hooks directory in the Git repository (usually in .git/hooks/)
git hooks

# Script names for specific hooks that can be added to the hooks directory
pre-commit, post-commit, pre-push, post-merge, etc.

# Make a hook script executable to ensure it's triggered when necessary
chmod +x <hook_script>
```

### Trabalhar com Patches

```git
# Generate a patch file for a specific commit
git format-patch <commit_id>

# Apply a patch to the current branch
git apply <patch_file>

# Apply a patch using the "git am" (apply mailbox) command
git am <patch_file>
```

### Colabora��o

```git
# Generate a request-pull summary with the changes between two commits
git request-pull <start_commit> <end_commit> <url>

# Summarize the commit history, listing authors and their contributions
git shortlog

# List all files tracked by Git
git ls-files

# Search for a specified pattern in files tracked by Git
git grep <pattern>
```

### Problemas de bissec��o, depura��o e desempenho

```git
# Begin a bisect session to find the commit that introduced a bug
git bisect start

# Mark a commit as "bad," indicating it contains the bug
git bisect bad <commit_id>

# Mark a commit as "good," indicating it does not contain the bug
git bisect good <commit_id>

# End the bisect session and return to the original branch/commit
git bisect reset

# Verify the integrity of the Git repository
git fsck

# Run garbage collection to optimize the repository's performance
git gc

# Remove untracked files and directories (use with caution)
git clean -df
```

### Dicas e truques

```git
# Interactively choose parts (hunks) of files to stage
git add -p

# Show the commit history and associated patches for a specific file
git log -p <file_name>

# Customize the format of the git log output
git log --pretty=format:"%h - %an, %ar : %s"

# Find text in commit messages (useful for locating specific changes)
git log --grep="<text>"

# Quickly view the changes in the working directory since the last commit
git diff --stat

# Display the branch history with decoration to see where branches have split or merged
git log --oneline --decorate --graph

# Stash changes in the working tree, including untracked files
git stash save -u

# Create an empty commit, useful while testing branch protection rules
git commit --allow-empty -m "Empty commit message"

# Set the git output pager to quit when the output is less than one screen, and not clear the screen after displaying
git config --global core.pager 'less -RFX'

# Use Git's auto-correct feature to fix mistyped commands
git config --global help.autocorrect 1

# List aliases for Git commands
git config --get-regexp alias

# Perform a dry run of merging without actually merging branches
git merge --no-commit --no-ff <branch_name>

# Show a tree-like representation of the repo's structure
git ls-tree --name-only -r -t HEAD
```