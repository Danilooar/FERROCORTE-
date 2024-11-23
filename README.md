# FERROCORTE-

<p><strong>FerroCorte</strong> é um programa simples em <code>C#</code> para auxiliar no gerenciamento de estoques de uma Matriz e uma Filial. Ele avalia níveis de estoque e sugere ações com base no Ponto de Pedido (PP) e no Estoque Máximo.</p>

 <h2>Funcionalidades</h2>
    <ul>
        <li>Entrada de dados:
            <ul>
                <li><strong>Ponto de Pedido (PP):</strong> Quantidade mínima que exige uma reposição.</li>
                <li><strong>Estoque Máximo:</strong> Capacidade máxima permitida no estoque.</li>
                <li><strong>Estoque atual da Matriz:</strong> Quantidade atual na matriz.</li>
                <li><strong>Estoque atual da Filial:</strong> Quantidade atual na filial.</li>
            </ul>
        </li>
        <li>Saída de ações recomendadas:
            <ul>
                <li>Comprar, transferir ou manter o estoque como está para Matriz e Filial.</li>
                <li>Quantidade sugerida para cada ação.</li>
            </ul>
        </li>
    </ul>

<h1>Lógica do Programa</h1>
<ul><h1>Para a Matriz:</h1>
<ol></ol>
  <li>Se o estoque atual for menor que o PP: COMPRAR a diferença.</li>
  <li> Se o estoque atual for maior que o Estoque Máximo: NÃO COMPRAR.</li>
  <li>Em qualquer outro caso: NÃO COMPRAR.</li>
  <ol></ol>
  <ol></ol>
  
  <h1>Para a Filial:</h1>
    
  <li>Se o estoque atual for menor que o PP: COMPRAR a diferença.</li>
  <li>Se o estoque atual for maior que o Estoque Máximo: TRANSFERIR o excedente.</li>
  <li>Em qualquer outro caso: NÃO COMPRAR.</li>


</ul>
  <h1>Para a Matriz:</h1>
  <ul>
    <li>Se o estoque atual for menor que o PP: COMPRAR a diferença.</li>
       <li>Se o estoque atual for menor que o PP: COMPRAR a diferença.</li>
       <li>Se o estoque atual for maior que o Estoque Máximo: NÃO COMPRAR.</li>
       <li>Em qualquer outro caso: NÃO COMPRAR.</li>
  </ul>
  

  <h1>Para a Filial:</h1>
  <ul>
    <li>Se o estoque atual for menor que o PP: COMPRAR a diferença.</li>
    <li>Se o estoque atual for maior que o Estoque Máximo: TRANSFERIR o excedente.</li> 
    <li>Em qualquer outro caso: NÃO COMPRAR.</li>  

  </ul>

<h1>Contribuições</h1>
<p>Contribuições são bem-vindas! Sugestões, correções ou novas funcionalidades podem ser enviadas por meio de issues ou pull requests.</p>
