# Projeto de Criação de Pastas Automática - Windows Forms em C#

## Descrição
Este projeto, desenvolvido em C# com Windows Forms, é uma aplicação desktop que permite ao usuário criar automaticamente uma estrutura de pastas baseada em entradas fornecidas nas caixas de texto da interface. O principal objetivo do projeto é facilitar a organização de arquivos em diferentes níveis de diretórios, ideal para estudantes ou profissionais que precisam estruturar documentos em categorias como disciplinas, unidades e aulas.

## Funcionalidades Principais:
1. **Interface Simples**: O usuário insere os nomes das pastas (como disciplina, unidade e aula) através de caixas de texto exibidas na interface gráfica.

2. **Criação de Pastas**: Com base nos valores inseridos pelo usuário, a aplicação cria uma estrutura de diretórios aninhados dentro de um caminho predefinido no sistema de arquivos.


## Estrutura do Projeto:
- **TextBoxes**: Três caixas de texto (`tbDisciplina`, `tbUnidade`, `tbAula`) para o usuário inserir os valores que serão usados como nomes das pastas.
- **Botão de Ação**: Um botão chamado `btCriarPastas` que, ao ser clicado, executa a criação das pastas.
- **Função de Criação de Pastas**: A função pega as entradas das TextBoxes e usa o método `Directory.CreateDirectory` para criar a estrutura de pastas no caminho especificado.

## Benefícios:
- **Organização Rápida**: Automatiza o processo de criação de pastas, permitindo que o usuário crie várias camadas de diretórios em um único clique.
- **Facilidade de Uso**: Com uma interface intuitiva, até mesmo usuários com pouca experiência técnica podem usar o programa para organizar seus arquivos.
- **Flexível e Customizável**: A estrutura de pastas pode ser adaptada a diferentes necessidades, como organização de projetos, disciplinas acadêmicas, ou até mesmo arquivos pessoais.

## Tecnologias Utilizadas:
- **C# (.NET Framework)**: Linguagem de programação utilizada para desenvolver a lógica do projeto.
- **Windows Forms**: Framework utilizado para criar a interface gráfica da aplicação.
- **Sistema de Arquivos (File System)**: A aplicação interage diretamente com o sistema de arquivos para criar diretórios.

## Exemplo de Uso:
1. O usuário abre o aplicativo e insere:
   - **Disciplina**: "Matemática"
   - **Unidade**: "Geometria"
   - **Aula**: "Aula 1"
   
2. Ao clicar no botão **"Criar Pastas"**, a aplicação cria a seguinte estrutura de pastas:

``C:\Users[usuario]\Desktop\Faculdade\Matemática\Geometria\Aula 1```

3. Uma mensagem de sucesso é exibida para o usuário confirmando a criação das pastas.

## Possíveis Melhorias Futuras:
- Permitir que o usuário selecione o diretório base onde as pastas serão criadas.
- Adicionar validação para garantir que o nome das pastas seja válido.
- Implementar uma interface mais moderna e responsiva.