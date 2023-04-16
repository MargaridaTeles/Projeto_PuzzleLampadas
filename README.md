# Projeto_PuzzleLampadas
https://github.com/MargaridaTeles/Projeto_PuzzleLampadas

## Autoria:
- Margarida Teles, a22204247
- Mariana Marques, a22207510

## Desenvolvimento:
Margarida
- Organização do GitHub
- MarkDown
- Desenvolvimento do Projeto
- Fluxograma

Mariana
- Auxilio no MarkDown
- Auxilio no Projeto e no Github

## Arquitetura da Solução:
A solução está organizada com dois arrays (um para os botões e outro para as Lâmpadas). Também contém uma enumeração num ficheiro designado por LampadaEstado.cs, este vai auxiliar os switchs feitos entre as Lâmpadas.
Enquanto o utilizador não pressionar seis vezes os botões, o programa informa o jogador em que ronda é que vai, quantas lampadas existem e quanto botões e pede também para que se escolha um botão.
De seguinda, o programa verifica se o número inserido que conjuga com os botões existentes, caso não conjugue então pede para que se insira um novo valor.
Após ser validado o valor inserido o programa basicamente faz switch:

  - 1 - Lampada Esquerda Liga; (se tiver ligada desliga)
  - 2 - Lampada Esquerda Liga e Meio Liga; (se a esquerda tiver ligada, desliga e liga a do meio)
  - 3 - Lampada Meio e Direita Ligam; (se a do meio tiver ligada, desliga e liga a da direita)
  
O programa também informa o utilizador de quais Lâmpadas foram ligadas.

Caso o utilizador ligue todas as Lâmpadas (3) e tiver pressionado 6 ou menos vezes, este VENCE. Senão este PERDE.

### Fluxograma:
![Diagrama sem nome (2)](https://user-images.githubusercontent.com/115217401/232325523-f2ed4a16-ee5b-4d82-b3e6-d60208cf6e8f.png)


## Referências
[PDF disponibilizado pelo Professor Nuno - Enumeration flags](https://moodle.ensinolusofona.pt/pluginfile.php/569962/mod_resource/content/1/aula03.pdf)

