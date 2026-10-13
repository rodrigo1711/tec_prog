var menuIcon = document.querySelector('.menu-icon');
var ul = document.querySelector('.ul');

menuIcon.addEventListener('click', ()=>{
    
    if(ul.classList.contains('ativo')){
        ul.classList.remove('ativo');
        document.querySelector('.menu-icon img') .src='img/menu.png';
    }
    else{
        ul.classList.add('ativo');
        document.querySelector('.menu-icon img') .src='img/close.png';
    }

});

class Orcamento {
    constructor(nome, email, monitoramento, instalacao, manuntencao) {
        this.nome = nome;
        this.email = email;
        this.monitoramento = monitoramento;
        this.instalacao = instalacao;
        this.manuntencao = manuntencao;
    }
};

function ArmazenaDados() {
    nome = document.getElementById("nome").value;
    email = document.getElementById("email").value;
    monitoramento = document.getElementById("monitoramento").value;
    instalacao = document.getElementById("instalacao").value;
    manuntencao = document.getElementById("manuntencao").value;
    orcamento = new Orcamento(nome, email, monitoramento, instalacao, manuntencao);
    localStorage.setItem("orcamento", JSON.stringify(orcamento));    
    
};

function mostrarAlerta() {

    alert("Enviado");
};

class Inicio {
    constructor(email) {
        this.email = email;
    }
};

function ArmazenaDados1(){
    email = document.getElementById("email").value;
    inicio = new Inicio(email);
    localStorage.setItem("inicio", JSON.stringify(inicio));

};

/*function notificarEmail(){
    alert("Enviado");
};
*/

class Contato {
    constructor(nome, email, mensagem) {
        this.nome = nome;
        this.email = email;
        this.mensagem = mensagem;
    }

};

function ArmazenaDados2() {
    nome = document.getElementById("nome").value;
    email = document.getElementById("email").value;
    mensagem = document.getElementById("mensagem").value;
    contato = new Contato(nome, email, mensagem);
    localStorage.setItem("Contato", JSON.stringify(Contato));
};
