# AI-8-puzzle

## 1. Pesquisar  e resumir os algoritmos de busca informados: 

### a. Greedy Search
R: Greedy Search, sempre faz a escolha que parece ser a melhor naquele momento. Isso significa que ele faz uma escolha ideal localmente, na esperança de que essa escolha leve a uma solução ideal globalmente. Ou seja, o algoritmo escolhe a melhor opção no nó atual, sem levar em consideração os seus filhos, podendo assim errar em determinados casos.

Como você decide qual escolha é ideal?

Suponha que você tenha uma função objetiva que precise ser otimizada (maximizada ou minimizada) em um determinado momento. Um algoritmo ganancioso faz escolhas gananciosas em cada etapa para garantir que a função objetivo seja otimizada. O algoritmo Greedy tem apenas uma chance de calcular a solução ideal para que nunca volte e reverta a decisão.


### b. A* Search (é condição para questão 2 entender muito bem)
R: Em ciência da computação, o A* (pronuncia-se A star) é um algoritmo de computador que é amplamente utilizado para "pathfinding", ou seja, o processo de encontrar o melhor caminho entre o ponto A e o ponto B, chamados de nós. Possui boa performance e precisão.

Funcionamento do algoritmo: O primeiro passo em pathfinding é dividir a área de procura em uma grade quadrada. Este método particular reduz nossa área de procura a uma ordem simples bi-dimensional. Cada ítem na ordem representa um dos quadrados na grade e seu estado é registrado como passável ou não-passável. O caminho é achado encontrando quais quadrados nós deveríamos tomar para ir de A à B. Uma vez que o caminho é achado, nossa entidade move do centro de um quadrado ao centro do próximo e assim sucessivamente até que o objetivo é alcançado.

### c. Graph Search




## 2. Solucionar na linguagem de sua preferência o problema 8 puzzle

### a. O programa deve inicializar o estado inicial do jogo (matriz 3 x 3) - pode ser um arquivo, aleatoriamente ou diretamente no código

### b. O arquivo contém o valor 0 para o espaço

### c. A interface pode ser CHUI (caracter), GUI (Graphical) ou Web

### d. Testes devem ser automatizados (não é obrigatório, mas é um "plus")



### Dicas: 

- a. Leia antes https://www.cs.princeton.edu/courses/archive/fall15/cos226/assignments/8puzzle.html

- b. Entender  Hamming priority function e  Manhattan priority function.

Pode ser feito em dupla ou individual.

A entrega deve ser feita no GIT (GitHub ou GitLab - será analisada a contribuição dos participantes para o projeto) a pergunta um pode estar respondida na documentação do projeto o código deve ter licença MIT. 
