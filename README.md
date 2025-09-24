# Arquivos, Diretórios e Streams

## Classe File

Fornece métodos estáticos para a criação, cópia, exclusão, movimentação e abertura de um único arquivo e auxilia na criação de objetos FileStream. <br> Para declarar com caminhos de arquivos, recomenda-se o uso do *caractere verbatim* ( `@` ), que irá ler todos os caracteres de maneira literal.

| Método | Descrição |
|--------|-----------|
| AppendAllLines(String, IEnumerable<String>) | Acrescenta linhas a um arquivo e fecha o arquivo. Se o arquivo especificado não existir, esse método criará um arquivo, gravará as linhas especificadas no arquivo e fechará o arquivo. |
| AppendAllLines(String, IEnumerable<String>, Encoding) | Acrescenta linhas a um arquivo usando uma codificação especificada e fecha o arquivo. Se o arquivo especificado não existir, esse método criará um arquivo, gravará as linhas especificadas no arquivo e fechará o arquivo. |
| AppendAllLinesAsync(String, IEnumerable<String>, CancellationToken) | Acrescenta as linhas de forma assíncrona a um arquivo e fecha o arquivo. Se o arquivo especificado não existir, esse método criará um arquivo, gravará as linhas especificadas no arquivo e fechará o arquivo. |
| AppendAllLinesAsync(String, IEnumerable<String>, Encoding, CancellationToken) | Acrescenta as linhas de forma assíncrona a um arquivo usando uma codificação especificada e fecha o arquivo. Se o arquivo especificado não existir, esse método criará um arquivo, gravará as linhas especificadas no arquivo e fechará o arquivo. |
| AppendAllText(String, String) | Abre um arquivo, acrescenta a cadeia de caracteres especificada ao arquivo e fecha o arquivo. Se o arquivo não existir, esse método criará um arquivo, gravará a cadeia de caracteres especificada no arquivo e fechará o arquivo. |
| AppendAllText(String, String, Encoding) | Acrescenta a cadeia de caracteres especificada ao arquivo usando a codificação especificada, criando o arquivo se ele ainda não existir. |
| AppendAllTextAsync(String, String, CancellationToken) | Abre um arquivo de forma assíncrona ou cria um arquivo se ele ainda não existir, acrescenta a cadeia de caracteres especificada ao arquivo e fecha o arquivo. |
| AppendAllTextAsync(String, String, Encoding, CancellationToken) | Abre um arquivo de forma assíncrona ou cria o arquivo se ele ainda não existir, acrescenta a cadeia de caracteres especificada ao arquivo usando a codificação especificada e fecha o arquivo. |
| AppendText(String) | Cria um StreamWriter que acrescenta texto codificado utf-8 a um arquivo existente ou a um novo arquivo se o arquivo especificado não existir. |
| Copy(String, String) | Copia um arquivo existente para um novo arquivo. Não é permitido substituir um arquivo com o mesmo nome. |
| Copy(String, String, Boolean) | Copia um arquivo existente para um novo arquivo. A substituição de um arquivo com o mesmo nome é permitida. |
| Create(String) | Cria ou trunca e substitui um arquivo no caminho especificado. |
| Create(String, Int32) | Cria ou trunca e substitui um arquivo no caminho especificado, especificando um tamanho de buffer. |
| Create(String, Int32, FileOptions) | Cria ou substitui um arquivo no caminho especificado, especificando um tamanho de buffer e opções que descrevem como criar ou substituir o arquivo. |
| CreateSymbolicLink(String, String) | Cria um link simbólico de arquivo identificado por path que aponta para pathToTarget. |
| CreateText(String) | Cria ou abre um arquivo para gravar texto codificado em UTF-8. Se o arquivo já existir, seu conteúdo será substituído. |
| Decrypt(String) | Descriptografa um arquivo criptografado pela conta atual usando o método Encrypt(String). |
| Delete(String) | Exclui o arquivo especificado. |
| Encrypt(String) | Criptografa um arquivo para que somente a conta usada para criptografar o arquivo possa descriptografá-lo. |
| Exists(String) | Determina se o arquivo especificado existe. |
| GetAttributes(SafeFileHandle) | Obtém o FileAttributes especificado do arquivo ou diretório associado ao fileHandle. |
| GetAttributes(String) | Obtém o FileAttributes do arquivo no caminho. |
| GetCreationTime(SafeFileHandle) | Retorna a hora de criação do arquivo ou diretório especificado. |
| GetCreationTime(String) | Retorna a data e a hora de criação do arquivo ou diretório especificado. |
| GetCreationTimeUtc(SafeFileHandle) | Retorna a data e a hora de criação, em UTC (Tempo Universal Coordenado), do arquivo ou diretório especificado. |
| GetCreationTimeUtc(String) | Retorna a data e a hora de criação, em UTC (Tempo Universal Coordenado), do arquivo ou diretório especificado. |
| GetLastAccessTime(SafeFileHandle) | Retorna a data e a hora do último acesso do arquivo ou diretório especificado. |
| GetLastAccessTime(String) | Retorna a data e a hora em que o arquivo ou diretório especificado foi acessado pela última vez. |
| GetLastAccessTimeUtc(SafeFileHandle) | Retorna a data e a hora do último acesso, em UTC (Tempo Universal Coordenado), do arquivo ou diretório especificado. |
| GetLastAccessTimeUtc(String) | Retorna a data e a hora, em UTC (Tempo Universal Coordenado), que o arquivo ou diretório especificado foi acessado pela última vez. |
| GetLastWriteTime(SafeFileHandle) | Retorna a data e a hora da última gravação do arquivo ou diretório especificados. |
| GetLastWriteTime(String) | Retorna a data e a hora em que o arquivo ou diretório especificado foi gravado pela última vez. |
| GetLastWriteTimeUtc(SafeFileHandle) | Retorna a data e a hora da última gravação, em UTC (Tempo Universal Coordenado), do arquivo ou diretório especificado. |
| GetLastWriteTimeUtc(String) | Retorna a data e a hora, em UTC (Tempo Universal Coordenado), em que o arquivo ou diretório especificado foi gravado pela última vez. |
| GetUnixFileMode(SafeFileHandle) | Obtém o UnixFileMode do identificador de arquivo especificado. |
| GetUnixFileMode(String) | Obtém o UnixFileMode do arquivo no caminho. |
| Move(String, String) | Move um arquivo especificado para um novo local, fornecendo a opção para especificar um novo nome de arquivo. |
| Move(String, String, Boolean) | Move um arquivo especificado para um novo local, fornecendo as opções para especificar um novo nome de arquivo e substituir o arquivo de destino se ele já existir. |
| Open(String, FileMode) | Abre um FileStream no caminho especificado com acesso de leitura/gravação sem compartilhamento. |
| Open(String, FileMode, FileAccess) | Abre um FileStream no caminho especificado, com o modo e o acesso especificados sem compartilhamento. |
| Open(String, FileMode, FileAccess, FileShare) | Abre um FileStream no caminho especificado, tendo o modo especificado com acesso de leitura, gravação ou leitura/gravação e a opção de compartilhamento especificada. |
| Open(String, FileStreamOptions) | Inicializa uma nova instância da classe FileStream com o caminho especificado, o modo de criação, a permissão de leitura/gravação e compartilhamento, o acesso que outros FileStreams podem ter para o mesmo arquivo, o tamanho do buffer, opções de arquivo adicionais e o tamanho da alocação. |
| OpenHandle(String, FileMode, FileAccess, FileShare, FileOptions, Int64) | Inicializa uma nova instância da classe SafeFileHandle com o caminho especificado, o modo de criação, a permissão de leitura/gravação e compartilhamento, o acesso que outros SafeFileHandles podem ter para o mesmo arquivo, opções de arquivo adicionais e o tamanho da alocação. |
| OpenRead(String) | Abre um arquivo existente para leitura. |
| OpenText(String) | Abre um arquivo de texto codificado em UTF-8 existente para leitura. |
| OpenWrite(String) | Abre um arquivo existente ou cria um novo arquivo para gravação. |
| ReadAllBytes(String) | Abre um arquivo binário, lê o conteúdo do arquivo em uma matriz de bytes e fecha o arquivo. |
| ReadAllBytesAsync(String, CancellationToken) | Abre um arquivo binário de forma assíncrona, lê o conteúdo do arquivo em uma matriz de bytes e fecha o arquivo. |
| ReadAllLines(String) | Abre um arquivo de texto, lê todas as linhas do arquivo e fecha o arquivo. |
| ReadAllLines(String, Encoding) | Abre um arquivo, lê todas as linhas do arquivo com a codificação especificada e fecha o arquivo. |
| ReadAllLinesAsync(String, CancellationToken) | Abre um arquivo de texto de forma assíncrona, lê todas as linhas do arquivo e fecha o arquivo. |
| ReadAllLinesAsync(String, Encoding, CancellationToken) | Abre um arquivo de texto de forma assíncrona, lê todas as linhas do arquivo com a codificação especificada e fecha o arquivo. |
| ReadAllText(String) | Abre um arquivo de texto, lê todo o texto no arquivo e fecha o arquivo. |
| ReadAllText(String, Encoding) | Abre um arquivo, lê todo o texto no arquivo com a codificação especificada e fecha o arquivo. |
| ReadAllTextAsync(String, CancellationToken) | Abre um arquivo de texto de forma assíncrona, lê todo o texto no arquivo e fecha o arquivo. |
| ReadAllTextAsync(String, Encoding, CancellationToken) | Abre um arquivo de texto de forma assíncrona, lê todo o texto no arquivo com a codificação especificada e fecha o arquivo. |
| ReadLines(String) | Lê as linhas de um arquivo. |
| ReadLines(String, Encoding) | Leia as linhas de um arquivo que tem uma codificação especificada. |
| ReadLinesAsync(String, CancellationToken) | Lê as linhas de um arquivo de forma assíncrona. |
| ReadLinesAsync(String, Encoding, CancellationToken) | Lê de forma assíncrona as linhas de um arquivo que tem uma codificação especificada. |
| Replace(String, String, String) | Substitui o conteúdo de um arquivo especificado pelo conteúdo de outro arquivo, excluindo o arquivo original e criando um backup do arquivo substituído. |
| Replace(String, String, String, Boolean) | Substitui o conteúdo de um arquivo especificado pelo conteúdo de outro arquivo, excluindo o arquivo original e criando um backup do arquivo substituído e, opcionalmente, ignora erros de mesclagem. |
| ResolveLinkTarget(String, Boolean) | Obtém o destino do link de arquivo especificado. |
| SetAttributes(SafeFileHandle, FileAttributes) | Define o FileAttributes especificado do arquivo ou diretório associado ao fileHandle. |
| SetAttributes(String, FileAttributes) | Define o FileAttributes especificado do arquivo no caminho especificado. |
| SetCreationTime(SafeFileHandle, DateTime) | Define a data e a hora em que o arquivo ou diretório foi criado. |
| SetCreationTime(String, DateTime) | Define a data e a hora em que o arquivo foi criado. |
| SetCreationTimeUtc(SafeFileHandle, DateTime) | Define a data e a hora, em UTC (Tempo Universal Coordenado), que o arquivo ou diretório foi criado. |
| SetCreationTimeUtc(String, DateTime) | Define a data e a hora, em UTC (Tempo Universal Coordenado), que o arquivo foi criado. |
| SetLastAccessTime(SafeFileHandle, DateTime) | Define a data e a hora em que o arquivo ou diretório especificado foi acessado pela última vez. |
| SetLastAccessTime(String, DateTime) | Define a data e a hora em que o arquivo especificado foi acessado pela última vez. |
| SetLastAccessTimeUtc(SafeFileHandle, DateTime) | Define a data e a hora, em UTC (Tempo Universal Coordenado), que o arquivo ou diretório especificado foi acessado pela última vez. |
| SetLastAccessTimeUtc(String, DateTime) | Define a data e a hora, em UTC (Tempo Universal Coordenado), que o arquivo especificado foi acessado pela última vez. |
| SetLastWriteTime(SafeFileHandle, DateTime) | Define a data e a hora em que o arquivo ou diretório especificado foi gravado pela última vez. |
| SetLastWriteTime(String, DateTime) | Define a data e a hora em que o arquivo especificado foi gravado pela última vez. |
| SetLastWriteTimeUtc(SafeFileHandle, DateTime) | Define a data e a hora, em UTC (Tempo Universal Coordenado), em que o arquivo ou diretório especificado foi gravado pela última vez. |
| SetLastWriteTimeUtc(String, DateTime) | Define a data e a hora, em UTC (Tempo Universal Coordenado), em que o arquivo especificado foi gravado pela última vez. |
| SetUnixFileMode(SafeFileHandle, UnixFileMode) | Define o UnixFileMode especificado do identificador de arquivo especificado. |
| SetUnixFileMode(String, UnixFileMode) | Define o UnixFileMode especificado do arquivo no caminho especificado. |
| WriteAllBytes(String, Byte[]) | Cria um novo arquivo, grava a matriz de bytes especificada no arquivo e fecha o arquivo. Se o arquivo de destino já existir, ele será truncado e substituído. |
| WriteAllBytesAsync(String, Byte[], CancellationToken) | Cria um novo arquivo de forma assíncrona, grava a matriz de bytes especificada no arquivo e fecha o arquivo. Se o arquivo de destino já existir, ele será truncado e substituído. |
| WriteAllLines(String, IEnumerable<String>) | Cria um novo arquivo, grava uma coleção de cadeias de caracteres no arquivo e fecha o arquivo. |
| WriteAllLines(String, IEnumerable<String>, Encoding) | Cria um novo arquivo usando a codificação especificada, grava uma coleção de cadeias de caracteres no arquivo e fecha o arquivo. |
| WriteAllLines(String, String[]) | Cria um novo arquivo, grava a matriz de cadeia de caracteres especificada no arquivo e fecha o arquivo. |
| WriteAllLines(String, String[], Encoding) | Cria um novo arquivo, grava a matriz de cadeia de caracteres especificada no arquivo usando a codificação especificada e fecha o arquivo. |
| WriteAllLinesAsync(String, IEnumerable<String>, CancellationToken) | Cria um novo arquivo de forma assíncrona, grava as linhas especificadas no arquivo e fecha o arquivo. |
| WriteAllLinesAsync(String, IEnumerable<String>, Encoding, CancellationToken) | Cria um novo arquivo de forma assíncrona, grava as linhas especificadas no arquivo usando a codificação especificada e fecha o arquivo. |
| WriteAllText(String, String) | Cria um novo arquivo, grava a cadeia de caracteres especificada no arquivo e fecha o arquivo. Se o arquivo de destino já existir, ele será truncado e substituído. |
| WriteAllText(String, String, Encoding) | Cria um novo arquivo, grava a cadeia de caracteres especificada no arquivo usando a codificação especificada e fecha o arquivo. Se o arquivo de destino já existir, ele será truncado e substituído. |
| WriteAllTextAsync(String, String, CancellationToken) | Cria um novo arquivo de forma assíncrona, grava a cadeia de caracteres especificada no arquivo e fecha o arquivo. Se o arquivo de destino já existir, ele será truncado e substituído. |
| WriteAllTextAsync(String, String, Encoding, CancellationToken) | Cria um novo arquivo de forma assíncrona, grava a cadeia de caracteres especificada no arquivo usando a codificação especificada e fecha o arquivo. Se o arquivo de destino já existir, ele será truncado e substituído. |

### Exceções do tipo IOException 

| Exceção | Descrição |
|---------|-----------|
| EndOfStreamException | Lançada quando uma tentativa é feita de ler além do final de um fluxo. |
| FileLoadException | Lançada quando um assembly de arquivo gerenciado é encontrado, mas não pode ser carregado. |
| FileNotFoundException | Lançada quando uma tentativa de acessar um arquivo inexistente no disco falha. |
| DirectoryNotFoundException | Lançada quando parte de um caminho de arquivo ou diretório não é encontrada. |
| DriveNotFoundException | Lançada quando uma unidade especificada em um caminho não é encontrada. |
| PathTooLongException | Lançada quando um caminho ou nome de arquivo excede o comprimento máximo definido pelo sistema. |
| PipeException | Lançada quando ocorre um erro em operações com **pipes** (tubulações anônimas ou nomeadas). |
| IsolatedStorageException | Lançada quando ocorre um erro em operações de **armazenamento isolado**. |
| UnauthorizedAccessException | Embora derive de `SystemException`, é frequentemente relacionada a I/O: lançada quando o sistema não tem permissão de acesso ao arquivo ou diretório. |
| NotSupportedException | Também não é filha direta de `IOException`, mas frequentemente lançada em I/O quando uma operação não é suportada para o formato ou fluxo usado. |
