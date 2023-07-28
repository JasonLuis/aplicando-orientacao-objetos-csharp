# Propriedade ou atributo?

## No C#, um atributo é uma variável declarada dentro de uma classe que armazena dados associados a uma instância específica desta classe e uma propriedade é uma abstração que fornece um meio de acessar e modificar os valores dos atributos de uma classe, encapsulando a lógica de leitura e escrita. Veja o exemplo de código abaixo que contém uma classe com um atributo e uma propriedade:

<pre class="prettyprint"><code class="hljs language-csharp"><span class="hljs-keyword">class</span> <span class="hljs-title">Filme</span>
{
    <span class="hljs-keyword">public</span> <span class="hljs-built_in">string</span> Titulo;

    <span class="hljs-keyword">public</span> <span class="hljs-built_in">int</span> Orcamento { <span class="hljs-keyword">get</span>; <span class="hljs-keyword">set</span>; }
}
</code><button type="button" class="clipit">Copiar código</button></pre>

## Um exemplo da instância desta classe seria:

<pre class="prettyprint"><code class="hljs language-java"><span class="hljs-type">Filme</span> <span class="hljs-variable">matrix</span> <span class="hljs-operator">=</span> <span class="hljs-keyword">new</span> <span class="hljs-title class_">Filme</span>();
matrix.Titulo = <span class="hljs-string">"Matrix"</span>;
matrix.Orcamento = <span class="hljs-number">63</span>;
</code><button type="button" class="clipit">Copiar código</button></pre>
