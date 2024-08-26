Sistema de Gestão de Alunos
Descrição
Este sistema foi desenvolvido em C# utilizando o Windows Forms para gerenciar as notas e a frequência dos alunos de uma turma. O sistema permite o cadastro de alunos, visualização de médias e frequências, e armazena os dados em um arquivo XML.

Pré-requisitos

•	.NET Framework 4.7.2 ou superior.
•	O diretório C:\dadosxml deve existir no disco C: e conter um arquivo XML chamado alunos.xml com os dados dos alunos no formato correto.

Execução do Sistema

1.	Abra o projeto no Visual Studio.
2.	Compile o projeto.
3.	Execute o projeto a partir do Visual Studio ou clicando duas vezes no arquivo executável gerado na pasta bin\Debug ou bin\Release.

Utilização

•	Cadastro: Utilize o formulário de cadastro para adicionar novos alunos, suas respectivas notas e frequência.
•	Listar: Use o formulário de listagem para visualizar as médias dos alunos e a média geral da turma.

Lista de Premissas Assumidas

•	Formato do Arquivo XML: O arquivo alunos.xml deve seguir a estrutura esperada pelo sistema, com a lista de alunos contendo os campos Nome, Notas e Frequencia.
•	Diretório de Armazenamento: O sistema assume que o diretório C:\dadosxml existe e tem permissões adequadas para leitura e gravação de arquivos.
•	Dados dos Alunos: Todos os alunos devem ter pelo menos 5 notas registradas para que os cálculos sejam realizados corretamente.

Decisões de Projeto

•	Armazenamento: O sistema utiliza XML para armazenar e gerenciar os dados dos alunos de forma persistente.
•	Validação: O sistema realiza validação básica para garantir que todos os alunos tenham notas suficientes antes de calcular as médias.
•	Interface: A interface do usuário foi projetada para ser simples e clara, com DataGridView para exibição de dados e botões para navegação.

Informações Adicionais

•	Caminho do Arquivo XML: Certifique-se de que o diretório C:\dadosxml exista antes de executar o sistema. Caso contrário, você precisará ajustar o caminho do arquivo no código.
•	Estilo: A interface gráfica foi ajustada para oferecer uma experiência de usuário agradável, com cores e fontes personalizadas.

