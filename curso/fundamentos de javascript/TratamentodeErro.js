function tratarErroELancar(erro){
    throw new Error('Error404')
}

function iprimirNomeGritado(obj){
    try{
        console.log(obj.name.toUpperCase() + '!!!')
    } catch(e){
        tratarErroELancar(e)
    } finally{
        console.log('POrraa')
    }

}

const obj = {Nome: 'roberto'}
iprimirNomeGritado(obj)