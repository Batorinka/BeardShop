<template>
    <div id="admin">
        <h1>admin</h1
        <nav v-bind:class="active" v-on:click.prevent>
            <a href="#" class="home" v-on:click="makeActive('home')">�������</a>
            <a href="#" class="projects" v-on:click="makeActive('projects')">�������</a>
            <a href="#" class="services" v-on:click="makeActive('services')">������</a>
            <a href="#" class="contact" v-on:click="makeActive('contact')">��������</a>
        </nav>
        <p>������ ����� <b>{{active}}</b></p>
    </div>
</template>

<script>
    export default {
        name: "admin-component"
    };
    var demo = new Vue({
	
	    // DOM �������, � �������� ����������� ��������
	    el: '#admin',

        // ������ ������.
	    // ���������� �������� � ����������� �� ����������� ��������.
	    data: {
		    active: 'home'
	    },

	    // �������, ������� ����� ������������.
	    methods: {
		    makeActive: function(item){
			    // ����� ������ ����� ��������, ������������� ���������.
			    this.active = item;
		    }
	    }
    });
</script>