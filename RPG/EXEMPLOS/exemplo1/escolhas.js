// Função para exibir uma pergunta e obter a escolha do jogador
function fazerEscolha(pergunta, opcoes) {
    console.log(pergunta);
    for (let i = 0; i < opcoes.length; i++) {
    console.log(`${i + 1}. ${opcoes[i]}`);
    }

    // Obter a entrada do jogador
    let escolha = parseInt(prompt("Digite o número da sua escolha:"));

    // Validar a entrada do jogador
    while (isNaN(escolha) || escolha < 1 || escolha > opcoes.length) {
    escolha = parseInt(prompt("Escolha inválida. Digite novamente:"));
    }

    // Retornar a escolha do jogador
    return escolha;
}

  // Função para executar o jogo
function jogarJogo() {
    // Introdução do jogo
    console.log("Bem-vindo ao RPG em Escolha!");
    console.log("Você está em um castelo misterioso. O que você faz?");

    // Opções para o jogador
    const opcoes = ["Explorar o castelo", "Procurar por tesouros", "Enfrentar um monstro"];
    
    // Fazer a primeira escolha
    const primeiraEscolha = fazerEscolha("O que você faz?", opcoes);

    // Lógica para cada escolha
    if (primeiraEscolha === 1) {
    console.log("Você explora o castelo e encontra uma sala secreta.");
      // Continuar a história com base na escolha
      exibirFinalFeliz(); // Exibe o final feliz
    } else if (primeiraEscolha === 2) {
    console.log("Você procura por tesouros, mas acaba ativando uma armadilha.");
      // Continuar a história com base na escolha
      exibirFinalTriste(); // Exibe o final triste
    } else if (primeiraEscolha === 3) {
    console.log("Você enfrenta um monstro feroz e o derrota.");
      // Continuar a história com base na escolha
      exibirFinalTriste(); // Exibe o final triste
    }


}

// Função para exibir o final feliz
function exibirFinalFeliz() {
    console.log("Parabéns! Você alcançou o final feliz do jogo.");}
    // Exibir descrição e resultados do final feliz

    // Função para exibir o final triste
function exibirFinalTriste() {
    console.log("Infelizmente, você alcançou um final triste do jogo.");}
    // Exibir descrição e resultados do final triste

  // Iniciar o jogo
jogarJogo();

