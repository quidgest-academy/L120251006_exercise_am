/* eslint-disable @typescript-eslint/no-unused-vars */
import { computed, reactive, watch } from 'vue'
import _merge from 'lodash-es/merge'

import FormViewModelBase from '@/mixins/formViewModelBase.js'
import genericFunctions from '@quidgest/clientapp/utils/genericFunctions'
import modelFieldType from '@quidgest/clientapp/models/fields'

import hardcodedTexts from '@/hardcodedTexts.js'
import netAPI from '@quidgest/clientapp/network'
import qApi from '@/api/genio/quidgestFunctions.js'
import qFunctions from '@/api/genio/projectFunctions.js'
import qProjArrays from '@/api/genio/projectArrays.js'
/* eslint-enable @typescript-eslint/no-unused-vars */

/**
 * Represents a ViewModel class.
 * @extends FormViewModelBase
 */
export default class ViewModel extends FormViewModelBase
{
	/**
	 * Creates a new instance of the ViewModel.
	 * @param {object} vueContext - The Vue context
	 * @param {object} options - The options for the ViewModel
	 * @param {object} values - A ViewModel instance to copy values from
	 */
	// eslint-disable-next-line @typescript-eslint/no-unused-vars
	constructor(vueContext, options, values)
	{
		super(vueContext, options)
		// eslint-disable-next-line @typescript-eslint/no-unused-vars
		const vm = this.vueContext

		// The view model metadata
		_merge(this.modelInfo, {
			name: 'FR_006',
			area: 'T_005',
			actions: {
				recalculateFormulas: 'RecalculateFormulas_Fr_006',
				updateFilesTickets: 'UpdateFilesTicketsFr_006',
				setFile: 'SetFileFr_006'
			}
		})

		/** The primary key. */
		this.ValCodt_005 = reactive(new modelFieldType.PrimaryKey({
			id: 'ValCodt_005',
			originId: 'ValCodt_005',
			area: 'T_005',
			field: 'CODT_005',
			description: '',
		}).cloneFrom(values?.ValCodt_005))
		this.stopWatchers.push(watch(() => this.ValCodt_005.value, (newValue, oldValue) => this.onUpdate('t_005.codt_005', this.ValCodt_005, newValue, oldValue)))

		/** The used foreign keys. */
		this.ValCodt_002 = reactive(new modelFieldType.ForeignKey({
			id: 'ValCodt_002',
			originId: 'ValCodt_002',
			area: 'T_005',
			field: 'F_006',
			relatedArea: 'T_002',
			description: '',
		}).cloneFrom(values?.ValCodt_002))
		this.stopWatchers.push(watch(() => this.ValCodt_002.value, (newValue, oldValue) => this.onUpdate('t_005.codt_002', this.ValCodt_002, newValue, oldValue)))

		/** The remaining form fields. */
		this.ValDatre = reactive(new modelFieldType.Date({
			id: 'ValDatre',
			originId: 'ValDatre',
			area: 'T_005',
			field: 'F_001',
			description: computed(() => this.Resources.DATE18475),
		}).cloneFrom(values?.ValDatre))
		this.stopWatchers.push(watch(() => this.ValDatre.value, (newValue, oldValue) => this.onUpdate('t_005.datre', this.ValDatre, newValue, oldValue)))

		this.ValClientname = reactive(new modelFieldType.String({
			id: 'ValClientname',
			originId: 'ValClientname',
			area: 'T_005',
			field: 'F_002',
			maxLength: 50,
			description: computed(() => this.Resources.CLIENT_NAME26049),
		}).cloneFrom(values?.ValClientname))
		this.stopWatchers.push(watch(() => this.ValClientname.value, (newValue, oldValue) => this.onUpdate('t_005.clientname', this.ValClientname, newValue, oldValue)))

		this.ValEmail = reactive(new modelFieldType.String({
			id: 'ValEmail',
			originId: 'ValEmail',
			area: 'T_005',
			field: 'F_003',
			maxLength: 50,
			maskType: 'EM',
			description: computed(() => this.Resources.EMAIL_CONTACT20056),
		}).cloneFrom(values?.ValEmail))
		this.stopWatchers.push(watch(() => this.ValEmail.value, (newValue, oldValue) => this.onUpdate('t_005.email', this.ValEmail, newValue, oldValue)))

		this.ValPhone = reactive(new modelFieldType.String({
			id: 'ValPhone',
			originId: 'ValPhone',
			area: 'T_005',
			field: 'F_004',
			maxLength: 50,
			description: computed(() => this.Resources.PHONE_CONTACT15195),
		}).cloneFrom(values?.ValPhone))
		this.stopWatchers.push(watch(() => this.ValPhone.value, (newValue, oldValue) => this.onUpdate('t_005.phone', this.ValPhone, newValue, oldValue)))

		this.ValDescription = reactive(new modelFieldType.String({
			id: 'ValDescription',
			originId: 'ValDescription',
			area: 'T_005',
			field: 'F_005',
			maxLength: 50,
			blockWhen: {
				// eslint-disable-next-line @typescript-eslint/no-unused-vars
				fnFormula(params)
				{
					// Formula: emptyC([T_005->F_004])
					return qApi.emptyC(this.ValPhone.value)
				},
				dependencyEvents: ['fieldChange:t_005.phone'],
				isServerRecalc: false,
				isEmpty: qApi.emptyC,
			},
			description: computed(() => this.Resources.DESCRIPTION07383),
		}).cloneFrom(values?.ValDescription))
		this.stopWatchers.push(watch(() => this.ValDescription.value, (newValue, oldValue) => this.onUpdate('t_005.description', this.ValDescription, newValue, oldValue)))

		this.TableT_002F_002 = reactive(new modelFieldType.String({
			type: 'Lookup',
			id: 'TableT_002F_002',
			originId: 'ValTitle',
			area: 'T_002',
			field: 'F_002',
			maxLength: 50,
			description: computed(() => this.Resources.PROPERTY_TITLE56931),
		}).cloneFrom(values?.TableT_002F_002))
		this.stopWatchers.push(watch(() => this.TableT_002F_002.value, (newValue, oldValue) => this.onUpdate('t_002.title', this.TableT_002F_002, newValue, oldValue)))
	}

	/**
	 * Creates a clone of the current QFormFr006ViewModel instance.
	 * @returns {QFormFr006ViewModel} A new instance of QFormFr006ViewModel
	 */
	clone()
	{
		return new ViewModel(this.vueContext, { callbacks: this.externalCallbacks }, this)
	}

	static QPrimaryKeyName = 'ValCodt_005'

	get QPrimaryKey() { return this.ValCodt_005.value }
	set QPrimaryKey(value) { this.ValCodt_005.updateValue(value) }
}
