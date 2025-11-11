# 🧭 Two Pointers — Estrutura de Dados

> Técnica fundamental em algoritmos e estruturas de dados, usada para resolver problemas de forma eficiente em tempo linear.

---

## 🧠 O que é Two Pointers?

**Two Pointers** (ou “dois ponteiros”) é uma técnica em que **duas variáveis percorrem uma estrutura de dados ao mesmo tempo**, geralmente com **velocidades ou direções diferentes**, para **reduzir a complexidade de tempo** de algoritmos que normalmente usariam dois loops aninhados.

💡 **Em outras palavras:**
> “Usamos dois ponteiros para olhar para diferentes partes do array ao mesmo tempo, resolvendo o problema mais rápido.”

---

## ⚙️ Quando usar

A técnica *Two Pointers* é ideal quando você precisa:

- 🔹 Comparar pares de elementos dentro de um array ou lista  
- 🔹 Encontrar somas específicas (`Two Sum Sorted`)  
- 🔹 Remover duplicados de uma lista ordenada  
- 🔹 Inverter strings ou arrays  
- 🔹 Detectar ciclos em listas encadeadas  
- 🔹 Trabalhar com janelas deslizantes (*sliding window*)

---

## 🧩 Tipos de movimento dos ponteiros

| Tipo | Direção | Exemplo de uso |
|------|----------|----------------|
| **Opposite Direction** | Um no início e outro no fim | Soma de pares (`Two Sum`) |
| **Same Direction** | Ambos avançam | Remover duplicados |
| **Velocidades diferentes (Slow & Fast)** | Um avança 1 passo, outro 2 | Detectar ciclos em lista encadeada |

---

## 📊 Vantagens

✅ Reduz complexidade de `O(n²)` para `O(n)`  
✅ Usa espaço constante  
✅ Fácil de implementar  
✅ Excelente em listas e arrays ordenados

---

## ⚠️ Cuidados

🚫 Nem todo problema com pares precisa de *two pointers*.  
Use somente se os dados tiverem **ordem lógica** ou **relação entre índices**.  

> Exemplo: a técnica não funciona diretamente em arrays **não ordenados**, sem antes aplicar uma ordenação.

---

## 🧠 Resumo rápido

> **Two Pointers = Dois olhos olhando para o mesmo array, cada um de um lado.**  
> Enquanto se movem, eles se encontram onde a resposta está — rápido e elegante. ⚡

---

## 🧩 Visualização

1️⃣ Compara extremos  
2️⃣ Move os ponteiros conforme a lógica  
3️⃣ Continua até eles se cruzarem

---

## 🏁 Conclusão

A técnica **Two Pointers** é uma das mais poderosas para otimizar algoritmos de arrays e strings.  
Aprender a enxergar *padrões de movimento entre índices* é um passo fundamental rumo ao raciocínio de **nível sênior em algoritmos**. 💪

---

## 📚 Autor

**Julia Cardoso**  
👩‍💻 Engenheira da Computação | 💡 Neurotech & IA Enthusiast  
📎 [github.com/cardos0s](https://github.com/cardos0s)


