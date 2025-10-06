import { propsConverter } from './routeUtils.js'

export default function getFormsRoutes()
{
	return [
		{
			path: '/:culture/:system/:module/form/F_001/:mode/:id?',
			name: 'form-F_001',
			props: route => propsConverter(route),
			component: () => import('@/views/forms/FormF001/QFormF001.vue'),
			meta: {
				routeType: 'form',
				baseArea: 'U_PRF',
				humanKeyFields: ['ValUsername']
			}
		},
	]
}
