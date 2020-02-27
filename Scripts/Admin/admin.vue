<template>
    <div id="admin">
        <h1>admin</h1
        <nav v-bind:class="active" v-on:click.prevent>
            <a href="#" class="home" v-on:click="makeActive('home')">Главная</a>
            <a href="#" class="projects" v-on:click="makeActive('projects')">Проекты</a>
            <a href="#" class="services" v-on:click="makeActive('services')">Услуги</a>
            <a href="#" class="contact" v-on:click="makeActive('contact')">Контакты</a>
        </nav>
        <p>Выбран класс <b>{{active}}</b></p>
    </div>
</template>

<script>
    export default {
        name: "admin-component"
    };
    var demo = new Vue({
	
	    // DOM элемент, к которому прикреплена сущность
	    el: '#admin',

        // Начало модели.
	    // Определяем свойства и присваиваем им необходимые значения.
	    data: {
		    active: 'home'
	    },

	    // Функции, которые будем использовать.
	    methods: {
		    makeActive: function(item){
			    // Когда модель будет изменена, представление обновится.
			    this.active = item;
		    }
	    }
    });
</script>